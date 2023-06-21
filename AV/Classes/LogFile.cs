using System;
using System.IO;




namespace AV.Classes
{
    public class LogFile
    {

        private static readonly string logFile_path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\logfile\logfile.txt"));
        private FileStream logFile;
        private StreamWriter logFileStream;

        public LogFile()
        {
            if (!System.IO.File.Exists(logFile_path))
            {
                CreateEmptyFile(logFile_path);
            }
            this.logFile = System.IO.File.Open(logFile_path, FileMode.Append, FileAccess.Write, FileShare.Read);
            this.logFileStream = new StreamWriter(logFile);
        }
        private void CreateEmptyFile(string filename)
        {
            System.IO.File.Create(filename).Dispose();
        }
        public void printToLogFile(Record record)
        {
            try
            {
                this.logFileStream.WriteLine(record.ToString());
                this.logFileStream.Flush();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
