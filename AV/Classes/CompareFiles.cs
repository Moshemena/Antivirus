using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using AV.Classes;



namespace AV
{

    public class CompareFiles
    {
        private static readonly string whiltelist_Path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\whitelist\whitelist.txt"));
        private static readonly string blacklist_Path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\blacklist\blacklist.txt"));

        private FileStream whiteListFile;
        private StreamReader whiteListStream;
        private FileStream blackListFile;
        private StreamReader blackListStream;

        public CompareFiles() 
        {

            this.whiteListFile = System.IO.File.Open(whiltelist_Path, FileMode.Open, FileAccess.Read);
            this.whiteListStream = new StreamReader(this.whiteListFile);

            this.blackListFile = System.IO.File.Open(blacklist_Path, FileMode.Open, FileAccess.Read);
            this.blackListStream = new StreamReader(this.blackListFile);


        }

        public bool IsInWhitelist(string filename)
        {
            try
            {
                //Whiltelist
                //var bytesArrays = ByteArrayToChunks(this.whitelist, 16);

                //FILE TO CHECK
                byte[] file_bytes = System.IO.File.ReadAllBytes(filename);
                byte[] hash = Md5.MD5(file_bytes);

                string hashString = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                string lineOfText;
                while ((lineOfText = this.whiteListStream.ReadLine()) != null)
                {
                    if (lineOfText.Split(';')[0] == hashString)
                    {
                        this.whiteListFile.Position = 0;
                        this.whiteListStream.DiscardBufferedData();
                        return true;
                    }
                }
                this.whiteListFile.Position = 0;
                this.whiteListStream.DiscardBufferedData();
                

                return false;
            }
            catch (Exception ex)
            {
                Record record = new Record(logType.ERROR, ex.Message);
                AVEngine.printToLogFile(record);
                return false;
            }
        }


        public bool IsInBlacklist(string filename)
        {
            try
            {
                
                byte[] file_bytes = System.IO.File.ReadAllBytes(filename);
                byte[] hash = Md5.MD5(file_bytes);

                string hashString = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                string lineOfText;
                while ((lineOfText = this.blackListStream.ReadLine()) != null)
                {
                    if (lineOfText.Split(';')[0] == hashString)
                    {
                        this.blackListFile.Position = 0;
                        this.blackListStream.DiscardBufferedData();
                        return true;
                    }
                }
                this.blackListFile.Position = 0;
                this.blackListStream.DiscardBufferedData();

                return false;
            }
            catch (Exception ex)
            {
                Record record = new Record(logType.ERROR, ex.Message);
                AVEngine.printToLogFile(record);
                return false;
            }
        }
        public float CheckSimilarity(string suspiciousFile)
        {

            float similarity = 0;

            string similarityScriptPath = $"-u {Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\similarity\similarity.py"))}";
            string black_list_samples_paths = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\blacklist"));

            string[] filePaths = Directory.GetFiles(black_list_samples_paths, "*.exe", SearchOption.AllDirectories);
            foreach (string filePath in filePaths)
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = @"C:\Users\yoavb\AppData\Local\Programs\Python\Python39\python.exe";
                start.Arguments = string.Format("{0} {1}", similarityScriptPath, $"\"{suspiciousFile}\" \"{filePath}\"");
                start.UseShellExecute = false;
                start.CreateNoWindow = true;
                start.RedirectStandardOutput = true;
                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {

                        string result = reader.ReadToEnd();
                        result = result.Trim();

                        if (result != "")
                        {
                            //similarity = Int32.Parse(result);
                            similarity = float.Parse(result, CultureInfo.InvariantCulture.NumberFormat);
                            return similarity;
                        }
                    }
                }
            }

            return similarity;

        }

    }
}
