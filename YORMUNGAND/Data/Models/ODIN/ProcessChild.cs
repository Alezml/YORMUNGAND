using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class ProcessChild
    {
        public int id { get; set; }
        public Process processId { get; set; }
        public string startParams { get; set; }
        public int priority { get; set; }
        public virtual List<Machine> machineList { get; set; }
        public int maxCountMachines { get; set; }
        public int minCountMachines { get; set; }
        public virtual List<SchedulerProcess> SchedulerProcessesList { get; set; }
        public virtual List<QueueProcesses> QueueProcessesList { get; set; }
        public virtual List<DefaultQueueProcesses> DefaultQueueProcessesList { get; set; }
        public virtual List<QueueProcessLog> QueueProcessLogList { get; set; }
    }
}
