using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class ProcessChild : Process
    {
        private int id { get; set; }
        private Process processId { get; set; }
        private string startParams { get; set; }
        private int priority { get; set; }
        public virtual List<Machine> machineList { get; set; }
        private int maxCountMachines { get; set; }
        private int minCountMachines { get; set; }
        public virtual List<SchedulerProcess> SchedulerProcessesList { get; set; }
        public virtual List<DefaultQueueProcesses> DefaultQueueProcessesList { get; set; }
    }
}
