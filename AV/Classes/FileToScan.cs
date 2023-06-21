

namespace AV.Classes
{
    public class FileToScan
    {
        private MonitorName monitorName;
        private string path;
        private string info;

        public FileToScan(MonitorName monitorName, string path, string info)
        {
            this.monitorName = monitorName;
            this.path = path;
            this.Info = info;
       
        }

        public string Path { get => path; }
        public MonitorName MonitorName { get => monitorName; }
        public string Info { get => info; set => info = value; }

        public override bool Equals(object obj)
        {
            return obj is FileToScan scan &&
                   Path == scan.Path;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
