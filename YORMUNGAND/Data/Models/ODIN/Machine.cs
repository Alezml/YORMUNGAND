using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class Machine
    {
        public int id { get; set; }
        public string machineName { get; set; }
        public virtual List<ProcessChild> ProcessChildrenList { get; set; }
        public virtual List<QueueProcessLog> QueueProcessLogsList { get; set; }
    }
}
