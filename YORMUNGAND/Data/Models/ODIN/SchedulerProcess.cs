using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class SchedulerProcess
    {
        private int id { get; set; }
        private ProcessChild processChildId { get; set; }
        private DateTime timeStart { get; set; }
    }
}
