using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class Process
    {
        public int id { get; set; }
        public Guid BPprocessid { get; set; }
        public string ProcessName { get; set; }
        public string Responsible { get; set; }
        public virtual List<ProcessChild> ProcessChildrenList { get; set; }
    }
}
