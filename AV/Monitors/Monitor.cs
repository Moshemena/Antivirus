using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV
{
    abstract public class Monitor
    {
        protected Antivirus form;
        protected AVEngine engine;

        protected Monitor()
        {
            this.form = Antivirus.ReturnInstance();
            this.engine = Antivirus.ReturnAV();
        }
        public abstract void ActiveMonitor();
    }
}
