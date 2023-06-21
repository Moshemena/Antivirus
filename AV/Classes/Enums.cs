namespace AV
{
    public enum EnumGridView
    {
        GridFiles,
        GridRegistry,
        GridSystem,
        GridPorts,
        GridProcess,
        GridUser
    }
    public enum MonitorName
    {
        User_Scan,
        Files_Monitor,
        Registrys_Monitor,
        Ports_Monitor,
        Process_Monitor
    }
    public enum logType
    {
        INFO,
        USER,
        SCAN,
        ALERT,
        ERROR
    }
    public enum Malicious
    {
        Unknown = 0,
        Virus = 1,
        Similarty_virus = 2
    }
}

