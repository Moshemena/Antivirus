using System;


namespace AV
{
    public static class Md5
    {
        public static byte[] MD5(byte[] bytes)
        {
            try
            {
                byte[] hash;
                using (var md5 = System.Security.Cryptography.MD5.Create())
                {
                    hash = md5.ComputeHash(bytes);
                }
               
                return hash;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return null;
            }

        }
    }
}
