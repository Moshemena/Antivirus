using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AV.Classes;

namespace AV
{
    public class ProcessMonitor : Monitor
    {
        public override void ActiveMonitor()
        {

            // Set up a query to retrieve instances of the Win32_Process class
            // Create event query to be notified within 1 second of
            // a change in a service
            WqlEventQuery query = 
                new WqlEventQuery("__InstanceCreationEvent",
                new TimeSpan(0, 0, 10),
                "TargetInstance isa \"Win32_Process\"");

            // Create a new management scope
            ManagementScope scope = new ManagementScope("\\\\.\\root\\CIMV2");

            // Create a new event watcher
            ManagementEventWatcher watcher = new ManagementEventWatcher(scope, query);

            
            // Set up the event handler
            watcher.EventArrived += (s, e) =>
            {
                // Get the process name and ID
                ManagementBaseObject instance = (ManagementBaseObject)e.NewEvent["TargetInstance"];
                string processName = (string)instance["Name"];
                int processId = Convert.ToInt32((uint)instance["ProcessId"]);
                string executablePath = GetProcessExecutablePath(processId);


                string[] results = new string[] { $"{processName}", $"{processId}", $"{executablePath}" };
                
                if(executablePath != null)
                {
                    form.AddRow(EnumGridView.GridProcess, results);

                    string info = "pName:" + processName + "| pId:" + processId;

                    engine.QueueFileForScan(new FileToScan(MonitorName.Process_Monitor, executablePath, info));
                }

            };

            // Start the watcher
            watcher.Start();

            // Stop the watcher
            //watcher.Stop();
        }
        private string GetProcessExecutablePath(int processId)
        {
            try
            {
                string wmiQueryString = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + processId;
                using (var searcher = new ManagementObjectSearcher(wmiQueryString))
                {
                    using (var results = searcher.Get())
                    {
                        ManagementObject mo = results.Cast<ManagementObject>().FirstOrDefault();
                        if (mo != null)
                        {
                            return (string)mo["ExecutablePath"];
                        }
                    }
                }
            }
            catch (Win32Exception ex)
            {
                Record record = new Record(logType.ERROR, ex.Message, "", "");
                AVEngine.printToLogFile(record);
                throw;
            }
            catch (Exception ex)
            {
                Record record = new Record(logType.ERROR, ex.Message, "", "");
                AVEngine.printToLogFile(record);
                throw;
            }
            return null;
        }


    }
}
