using AV.Classes;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AV
{
    public class AVEngine
    {
        private Monitor fm;
        private static Queue<FileToScan> FilesToScan = new Queue<FileToScan>();
        private Queue<FileToScan> BadFiles = new Queue<FileToScan>();
        private readonly int Similarity_Threshold = 80;
        private Antivirus form;
        private Thread thread1;
        private Thread thread2;
        private Thread thread3;
        private Thread thread4;
        private Thread thread5;
        private Thread thread6;
        private CompareFiles cb;
        private static LogFile log = new LogFile();
        private AutoStartUp autoStart = new AutoStartUp();




        public AVEngine()
        {
            this.form = Antivirus.ReturnInstance();
            this.cb = new CompareFiles();
            //this.thread1 = new Thread(FilesMonitorThread);
            this.thread2 = new Thread(RegistryMonitorThread);
            //this.thread3 = new Thread(PortsMonitorThread);
            this.thread4 = new Thread(ProcessMonitorThread);
            this.thread5 = new Thread(WhiteListScan);
            this.thread6 = new Thread(BlackListScan);

        }

        public void Start()
        {
            Record record = new Record(logType.INFO, "System startup");
            printToLogFile(record);

            //WhiteList whiteList = new WhiteList();
            //whiteList.CreateWhiteList();

            //thread1.Start();
            thread2.Start();
            //thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
        }
        public static void printToLogFile(Record record)
        {
            log.printToLogFile(record);
        }
        private void FilesMonitorThread()
        {
            fm = new FilesMonitor();
            fm.ActiveMonitor();
        }
        private void RegistryMonitorThread()
        {
            fm = new RegistrysMonitor();
            fm.ActiveMonitor();
        }
        private void PortsMonitorThread()
        {
            fm = new PortsMonitor();
            fm.ActiveMonitor();
        }
        private void ProcessMonitorThread()
        {
            fm = new ProcessMonitor();
            fm.ActiveMonitor();
        }

        public void KillThreads()
        {
            try
            {
                thread1.Abort();
                thread2.Abort();
                thread3.Abort();
                thread4.Abort();
                thread5.Abort();
                thread6.Abort();
            }
            catch (Exception ex)
            {
                Record record = new Record(logType.ERROR, ex.Message);
                printToLogFile(record);
            }

        }
        public void QueueFileForScan(FileToScan fileToScan)
        {
            lock (FilesToScan)
            {
                if(!FilesToScan.Contains(fileToScan))
                {
                    FilesToScan.Enqueue(fileToScan);
                }
                
            }
        }
        private void WhiteListScan()
        {

            while (true) // Scanner thread loops until the program exits
            {
               
                FileToScan fileToScan = null;
                Record record = null;
                lock (FilesToScan)
                {
                    try
                    {
                        fileToScan = FilesToScan.Dequeue();


                    }
                    catch (Exception ex)
                    {
                        // Nothing in the queue
                    }
                }

                if (fileToScan != null)
                {
                    // Now, scan the file
                    if (this.cb.IsInWhitelist(fileToScan?.Path))
                    {

                        string[] results = new string[] { $"{fileToScan.MonitorName}", $"A safe file was scanned.", $"{fileToScan.Path}" };
                        form.AddRow(EnumGridView.GridSystem, results);

                        //Print to user mode tab
                        if (isUserScan(fileToScan.MonitorName))
                        {
                            string[] result = new string[] { $"A safe file was scanned.", $"{fileToScan.Path}" };

                            form.AddRow(EnumGridView.GridUser, result);
                        }

                        //Print to log file
                        record = new Record(logType.SCAN, "Whitelist", fileToScan.Info, results[2]);
                        printToLogFile(record);
                    }
                    else
                    {
                        BadFiles.Enqueue(fileToScan);
                    } 
                }
            }
        }


        private void BlackListScan()
        {     

            while (true) // Scanner thread loops until the program exits
            {
                FileToScan fileToScan = null; // To hold what we take out of the
                string[] results = null;
                Record record = null;

                lock (FilesToScan)
                {
                    try
                    {
                        fileToScan = BadFiles.Dequeue();
                    }
                    catch (Exception ex)
                    {
                        // Nothing in the queue
                    }
                }

                if (fileToScan != null)
                {
                    //flag == 0 -> Unknown
                    //flag == 1 -> VIRUS
                    //flag == 2 -> Similarty virus
                    int flag = 0;

                    float similarity = this.cb.CheckSimilarity(fileToScan?.Path);

                    // Now, scan the file
                    if (this.cb.IsInBlacklist(fileToScan?.Path))
                    {
                        results = new string[] { $"{fileToScan.MonitorName}", $"A VIRUS WAS DETECTED", $"{fileToScan.Path}" };
                        flag = 1;

                        form.AlertToUser("A virus was detected", fileToScan);
                        
                    }
                    //Similarity_Threshold = 85
                    else if (Math.Ceiling(similarity) >= Similarity_Threshold)
                    {
                       

                        results = new string[] { $"{fileToScan.MonitorName}", $"Similarity virus", $"{fileToScan.Path}" };
                        flag = 2;
                        form.AlertToUser("A similarity virus was detected Similarity result: "+ similarity, fileToScan);
                    }
                    else
                    {
                        results = new string[] { $"{fileToScan.MonitorName}", $"Unknown", $"{fileToScan.Path}" };
                    }

                    form.AddRow(EnumGridView.GridSystem, results);

                    if (isUserScan(fileToScan.MonitorName))
                    {
                        string[] result = new string[] { $"{results[1]}", $"{results[2]}" };

                        form.AddRow(EnumGridView.GridUser, result);
                    }

                    //Print to logfile

                    //Similarity
                    if (flag == 2)
                    {
                        string info = Malicious.Similarty_virus.ToString() + " Result: " + similarity;
                        record = new Record(logType.SCAN, info, fileToScan.Info, results[2]);
                        printToLogFile(record);
                    }
                    //Blacklist or Unknown
                    else
                    {
                        record = new Record(logType.SCAN, ((Malicious)flag).ToString(), fileToScan.Info, results[2]);
                        printToLogFile(record);
                    }
                }
            }
        }


       
        private bool isUserScan(MonitorName monitorName)
        {
            return monitorName == MonitorName.User_Scan;
        }



    }
}
