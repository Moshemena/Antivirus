using Microsoft.Win32;
using System;
using System.Linq;


namespace AV.Classes
{
    public class AutoStartUp
    {
        private static readonly string runPath = @"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string regKey = "Antivirus";

        public AutoStartUp() 
        {
            if (!RegistryKeyPersistence())
            {
               AutoStartup();
            }
        }
        private bool RegistryKeyPersistence()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(runPath, true);
            return (registryKey.GetValueNames().Contains(regKey));
        }
        private void AutoStartup()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(runPath, true);
                registryKey.SetValue(regKey, System.Reflection.Assembly.GetExecutingAssembly().Location);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }
        private void RemoveStartup()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(runPath, true);
                registryKey.DeleteValue(regKey);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

    }
}
