using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class Machine
    {
        private int id { get; set; }
        private string machineName { get; set; }
        public virtual List<ProcessChild> ProcessChildrenList { get; set; }
        public virtual List<QueueProcessLog> QueueProcessLogsList { get; set; }
    }
}
