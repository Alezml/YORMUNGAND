using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class ProcessView
    {
        public virtual IEnumerable<Process> OdinProcessList { set; get; }
        public virtual IEnumerable<BPAProcess> BpProcessList { set; get; }
    }
}
