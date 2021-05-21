using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class DefaultQueueProcesses
    {
        public int id { get; set; }
        public string typeOfSchedule { get; set; }
        public int paramDay { get; set; }
        public TimeSpan timeSpanStart { get; set; }
        public ProcessChild processChild { get; set; }
    }
}
