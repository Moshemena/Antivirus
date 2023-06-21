using System;


namespace AV.Classes
{
    public class Record
    {
        private logType type;
        private string info;
        private string additionalInfo;
        private string path;

        public Record(logType type, string info, string additionalInfo, string path)
        {
            this.Type = type;
            this.Info = info;
            this.AdditionalInfo = additionalInfo;
            this.Path = path;   
        }
        public Record(logType type, string info, string path)
        {
            this.Type = type;
            this.Info = info;
            this.Path = path;
        }
        public Record(logType type, string info)
        {
            this.Type = type;
            this.Info = info;

        }

        public logType Type { get => type; set => type = value; }
        public string Info { get => info; set => info = value; }
        public string AdditionalInfo { get => additionalInfo; set => additionalInfo = value; }
        public string Path { get => path; set => path = value; }

        public override string ToString()
        {
            if (this.AdditionalInfo == null && this.Path == null)
            {
                return String.Format("{0} - [ {1} ][ {2} ]", DateTime.Now, this.Type, this.Info);
            }
            else if (this.AdditionalInfo == null && this.Path != null)
            {
                
                return String.Format("{0} - [ {1} ][ {2} ][ {3} ]", DateTime.Now, this.Type, this.Info, this.Path);
            }
            else
            {
                return String.Format("{0} - [ {1} ][ {2} ][ {3} ][ {4} ]", DateTime.Now, this.Type, this.Info, this.AdditionalInfo, this.Path);
            }
            
        }
    }
}
