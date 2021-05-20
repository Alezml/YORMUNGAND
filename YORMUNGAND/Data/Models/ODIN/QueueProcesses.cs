using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class QueueProcesses
    {
        private int id { get; set; }
        private ProcessChild processChildId { get; set; }
        private DateTime needStartTime { get; set; }
        private int priority { get; set; }
        private bool isWorked { get; set; }
        private int minCountMachines { get; set; }
        public virtual List<ProcessChild> ProcessChildrenList { get; set; }
        public virtual List<QueueProcessLog> queueProcessLogsList { get; set; }
    }
}
