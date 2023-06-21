using AV.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;



namespace AV
{
    public partial class Antivirus : Form
    {

        private static Antivirus instance;
        private static AVEngine engine;
        private List<string> AlertList = new List<string>();
        public static Antivirus ReturnInstance()
        {
            return instance;
        }
        public static AVEngine ReturnAV()
        {
            return engine;
        }
        public Antivirus()
        {
            InitializeComponent();
            instance = this;
            engine = new AVEngine();
            engine.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridFiles.AutoSize = false;
            dataGridFiles.ScrollBars = ScrollBars.Both;
            this.FormClosing += Form1_Closing;
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Antivirus", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                Record r1 = new Record(logType.USER, "User closed the antivirus");
                AVEngine.printToLogFile(r1);

                Record r2 = new Record(logType.INFO, "System shutdown");
                AVEngine.printToLogFile(r2);

                engine.KillThreads();
                Environment.Exit(Environment.ExitCode);
            }
            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private DataGridView GetDataGridView(EnumGridView gridName)
        {
            switch (gridName)
            {
                case EnumGridView.GridFiles:
                    return dataGridFiles;

                case EnumGridView.GridRegistry:
                    return dataGridRegistry;

                case EnumGridView.GridPorts:
                    return dataGridPorts;

                case EnumGridView.GridProcess:
                    return dataGridProcess;

                case EnumGridView.GridSystem:
                    return dataGridSystem;

                case EnumGridView.GridUser:
                    return dataGridUser;
            }
            return null;
        }
    
        public void AddRow(EnumGridView gridName, string[] row)
        {
            try
            {
                DataGridView grid = GetDataGridView(gridName);
                grid.Invoke(new Action(() =>
                {
                    grid.Rows.Add(row);
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void ClearData(EnumGridView gridName)
        {
            try
            {
                DataGridView grid = GetDataGridView(gridName);
                grid.Invoke(new Action(() =>
                {
                    grid.Rows.Clear();
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog.InitialDirectory = @"C:/Desktop";
            //Your opendialog box title name.
            openFileDialog.Title = "Select file to be upload.";
            //which type file format you want to upload in database. just add them.
            openFileDialog.Filter = "Select Valid Document(*.exe;)|*.exe;";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog.FilterIndex = 1;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.CheckFileExists)
                    {

                        ClearData(EnumGridView.GridUser);

                        string path = System.IO.Path.GetFullPath(openFileDialog.FileName);

                        ScanFolderText.Text = path;

                        engine.QueueFileForScan(new FileToScan(MonitorName.User_Scan,path, "User scan"));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ScanFolder_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog openFolderbDialog = new FolderBrowserDialog();

            try
            {
                if (openFolderbDialog.ShowDialog() == DialogResult.OK)
                {

                    ClearData(EnumGridView.GridUser);

                    string path = openFolderbDialog.SelectedPath;

                    ScanFolderText.Text = path;

                    string[] files = System.IO.Directory.GetFiles(path, "*.exe", SearchOption.AllDirectories);

                    if (files.Length == 0)
                    {
                        MessageBox.Show("There are no *.exe files to scan");
                    }
                    else
                    {
                        foreach (var file in files)
                        {
                            engine.QueueFileForScan(new FileToScan(MonitorName.User_Scan, file, "User scan"));
                        }
                    }

                }
  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void AlertToUser(string message, FileToScan alertedFile)
        {

            string filePath = alertedFile.Path;
            string exeFile;

            //if (alertedFile.MonitorName == MonitorName.Ports_Monitor)
            //{
            //    exeFile = alertedFile.Info;
            //    exeFile += "\n\n" + alertedFile.Path;
            //}
            //else
            //{
            //    exeFile = System.IO.Path.GetFileName(filePath);
            //}

            exeFile = alertedFile.Info;
            exeFile += "\n\n" + alertedFile.Path;




            if (AddIfNotExist(filePath))
            {
                MessageBox.Show(
                    message + "\n" + exeFile,
                    "Alert",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            Record record = new Record(logType.ALERT, message, exeFile);

            AVEngine.printToLogFile(record);

        }
        private bool AddIfNotExist(string path)
        {

            if (!AlertList.Contains(path))
            {
                AlertList.Add(path);
                return true;
            }
            return false;
        }

    }
}
