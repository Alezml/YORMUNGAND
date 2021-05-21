using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class QueueProcesses
    {
        public int id { get; set; }
        public ProcessChild processChildId { get; set; }
        public DateTime needStartTime { get; set; }
        public int priority { get; set; }
        public bool isWorked { get; set; }
        public int minCountMachines { get; set; }
        //public virtual List<ProcessChild> ProcessChildrenList { get; set; }
        public virtual List<QueueProcessLog> queueProcessLogsList { get; set; }
    }
}
