using AV.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;

namespace AV
{
    public class RegistrysMonitor : Monitor
    {

        private static Timer aTimer;

        private static string[] registryRoots =
        {
             @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
             @"SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce",
        };

        public override void ActiveMonitor()
        {
           RegistryMonitor();
        }

        private void RegistryMonitor()
        {
            // Create a timer and set a two second interval.
            aTimer = new Timer();
            aTimer.Interval = 10000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {

            form.ClearData(EnumGridView.GridRegistry);
            var registrykeys_CurrentUser = GetRegistryKeys("CurrentUser");
            var registrykeys_LocalMachine = GetRegistryKeys("LocalMachine");

            var registrykeys = registrykeys_CurrentUser;
            registrykeys.AddRange(registrykeys_LocalMachine);

            foreach (var regKey in registrykeys)
            {

                string[] results;
                if (regKey.ExecutablePath.Substring(regKey.ExecutablePath.Length - 3) != "exe")
                {
                    results = new string[] { $"{regKey.Machine}", $"{regKey.Directory}", $"{regKey.RegistryKey}", $"{regKey.ExecutablePath.Split('"')[regKey.ExecutablePath.Split('"').Length == 1 ? 0 : 1]}" };
                }
                else
                {
                    results = new string[] { $"{regKey.Machine}", $"{regKey.Directory}", $"{regKey.RegistryKey}", $"{regKey.ExecutablePath}" };

                }
                string info = "RegistryKey:" + regKey.RegistryKey + "|Directory:" + regKey.Directory;

                engine.QueueFileForScan(new FileToScan(MonitorName.Registrys_Monitor ,results[3], info));
                form.AddRow(EnumGridView.GridRegistry,results);
            }
        }

        private List<dynamic> GetRegistryKeys(string machineType)
        {
            List<dynamic> valuesByNames = new List<dynamic>();

            foreach (string registryRoot in registryRoots)
            {
                try
                {
                    using (RegistryKey rootKey = GetRegistryKey(machineType).OpenSubKey(registryRoot))
                    {
                        if (rootKey != null)
                        {
                            List<dynamic> tempList = GetRegistryKeyAsDynamic(machineType, registryRoot, rootKey);

                            valuesByNames.AddRange(tempList);

                            rootKey.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Record record = new Record(logType.ERROR, ex.Message);
                    AVEngine.printToLogFile(record);
                    throw;
                }
            }

            return valuesByNames;
        }

        private RegistryKey GetRegistryKey(string machineType)
        {
            return machineType == "CurrentUser" ? Registry.CurrentUser : Registry.LocalMachine;
        }

        private List<dynamic> GetRegistryKeyAsDynamic(string machine, string registryRoot, RegistryKey rootKey)
        {
            List<dynamic> valuesByNames = new List<dynamic>();

            try
            {
                string[] valueNames = rootKey.GetValueNames();

                foreach (string currSubKey in valueNames)
                {
                    object value = rootKey.GetValue(currSubKey);

                    string[] path = registryRoot.Split(new[] { "\\" }, StringSplitOptions.None);
                    string directory = path[path.Length - 1];

                    valuesByNames.Add(new { Machine = machine, Directory = directory, RegistryKey = currSubKey, ExecutablePath = value.ToString() });
                }

                return valuesByNames;
            }
            catch (Exception ex)
            {
                Record record = new Record(logType.ERROR, ex.Message);
                AVEngine.printToLogFile(record);
                return null;
            }
        }

    }
}
