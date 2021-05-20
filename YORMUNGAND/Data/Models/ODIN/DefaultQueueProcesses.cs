using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class DefaultQueueProcesses
    {
        private int id { get; set; }
        private string typeOfSchedule { get; set; }
        private int paramDay { get; set; }
        private TimeSpan timeSpanStart { get; set; }
        private ProcessChild processChild { get; set; }
    }
}
