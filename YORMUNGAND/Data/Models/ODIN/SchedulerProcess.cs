using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class SchedulerProcess
    {
        public int id { get; set; }
        public ProcessChild processChildId { get; set; }
        public DateTime timeStart { get; set; }
    }
}
