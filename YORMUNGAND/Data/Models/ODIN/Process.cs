using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class Process
    {
        private int id { get; set; }
        private string ProcessName { get; set; }
        private string Responsible { get; set; }
        public virtual List<ProcessChild> ProcessChildrenList { get; set; }
    }
}
