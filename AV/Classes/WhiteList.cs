using System;
using System.IO;


namespace AV
{
     public class WhiteList
    {
        private readonly string whiltelist_Path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\blacklist\blacklist.txt"));
        private readonly string[] whiltelist_paths = new string[] {
            //@"C:\Windows",
            //@"C:\Program Files\Microsoft Visual Studio",
            //@"C:\Users\User\Desktop\whitelist_files"
            @"C:\Users\yoavb\Downloads\DEVELOP_SCENARIOS (2)"
        };


        private bool ScanFileToWhilteList(string filePath)
        {
            try
            {

                byte[] file_bytes = File.ReadAllBytes(filePath);

                byte[] hash = Md5.MD5(file_bytes);

                using (StreamWriter stream = File.AppendText(whiltelist_Path))
                {
                    string[] fileName = filePath.Split('\\');
                    string hashString = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    stream.WriteLine(hashString + ";" + fileName[fileName.Length-1]);
                    Console.WriteLine("Scan successfully: {0}", filePath);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }

        public bool CreateWhiteList()
        {
            try
            {

                foreach (string path in whiltelist_paths)
                {
                    string[] dirs = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);

                    foreach (string dir in dirs)
                    {
                        try
                        {
                            string[] filePaths = Directory.GetFiles(dir, "*.exe", SearchOption.AllDirectories);

                            foreach (string filePath in filePaths)
                            {
                                ScanFileToWhilteList(filePath);
                            }
                        } 
                        catch(Exception e) 
                        {
                            Console.WriteLine("Can't read " + dir);
                        }
                       
                    }
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }

        }

    }
}
