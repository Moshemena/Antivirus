using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AV.Classes;

namespace AV
{
    public class FilesMonitor : Monitor
    {
        private static string user = "yoavb";

        private static string[] paths =
        {
            $@"C:\Users\{user}\Desktop",
            $@"C:\Users\{user}\Downloads",
            $@"C:\Users\{user}\Favorites",
            $@"C:\Users\{user}\Music",
            $@"C:\Users\{user}\Pictures",
            $@"C:\Users\{user}\Videos",
            $@"C:\Users\{user}\AppData",
            $@"C:\ProgramData\Microsoft\Windows\Start Menu\Program\Startup"
        };

        public override void ActiveMonitor()
        {
            try
            {
                List<FileSystemWatcher> watchers = new List<FileSystemWatcher>();

                foreach (string path in paths)
                {
                    watchers.Add(MyWatcherFatory(path));
                }

                foreach (FileSystemWatcher watcher in watchers)
                {
                    watcher.EnableRaisingEvents = true;
                }
            }
            catch (Exception ex)
            {
                Record record = new Record(logType.ERROR, ex.Message, "", "");
                AVEngine.printToLogFile(record);
            }

        }

        FileSystemWatcher MyWatcherFatory(string path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(path);
            watcher.NotifyFilter = NotifyFilters.Attributes
                                      | NotifyFilters.CreationTime
                                      | NotifyFilters.DirectoryName
                                      | NotifyFilters.FileName
                                      | NotifyFilters.LastAccess
                                      | NotifyFilters.LastWrite
                                      | NotifyFilters.Security
                                      | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;
            watcher.Error += OnError;
            watcher.InternalBufferSize = 65536;
            watcher.Filter = "*.exe";
            watcher.IncludeSubdirectories = true;
            watcher.Path = path;
            return watcher;
        }


        private void OnCreated(object sender, FileSystemEventArgs e)
        {
  
            string[] results = new string[] { "Created", $"{e.FullPath}", "" };

            form.AddRow(EnumGridView.GridFiles, results);

            engine.QueueFileForScan(new FileToScan(MonitorName.Files_Monitor,e.FullPath, "File created"));
        }
        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            string[] results = new string[] { "Deleted", $"{e.FullPath}", "" };

            form.AddRow(EnumGridView.GridFiles, results);

            engine.QueueFileForScan(new FileToScan(MonitorName.Files_Monitor, e.FullPath, "File deleted"));
        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            string[] results = new string[] { "Changed", $"{e.FullPath}", "" };

            form.AddRow(EnumGridView.GridFiles, results);

            engine.QueueFileForScan(new FileToScan(MonitorName.Files_Monitor, e.FullPath, "File changed"));

        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            string[] results = new string[] { "Renamed", $"{e.OldFullPath}", $"{e.FullPath}" };

            form.AddRow(EnumGridView.GridFiles, results);
            engine.QueueFileForScan(new FileToScan(MonitorName.Files_Monitor, e.FullPath, "File renamed"));

        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            PrintException(e.GetException());
        }


        private void PrintException(Exception ex)
        {

            if (ex != null)
            {
                string[] results = new string[] { "Message", "Stacktrace", $"{ex.Message}" };

                form.AddRow(EnumGridView.GridFiles, results);

                Record record = new Record(logType.ERROR, ex.Message);
                AVEngine.printToLogFile(record);

            }
        }
    }
}
