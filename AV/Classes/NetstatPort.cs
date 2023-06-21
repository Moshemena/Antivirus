

namespace AV
{
    public class NetstatPort
    {
        private string protocol;
        private string localAddress;
        private string openPort;
        private string state;
        private int pid;
        private string processName;
        private string processPath;

        public NetstatPort(string protocol, string localAddress, string openPort, string state, int pid, string processName, string processPath)
        {
            this.Protocol = protocol;
            this.LocalAddress = localAddress;
            this.OpenPort = openPort;
            this.State = state;
            this.Pid = pid;
            this.ProcessName = processName;
            this.ProcessPath = processPath;
        }

        public string Protocol { get => protocol; set => protocol = value; }
        public string LocalAddress { get => localAddress; set => localAddress = value; }
        public string OpenPort { get => openPort; set => openPort = value; }
        public string State { get => state; set => state = value; }
        public int Pid { get => pid; set => pid = value; }
        public string ProcessName { get => processName; set => processName = value; }
        public string ProcessPath { get => processPath; set => processPath = value; }

        public override string ToString()
        {

            return string.Format("{0}, localAddress: {1}, Port: {2}, State: {3}, PID: {4}, PName: {5}", this.protocol, this.localAddress, this.openPort, this.state, this.pid, this.processName);
        }
    }

}
