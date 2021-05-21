using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class QueueProcessLog
    {
        public string id { get; set; }
        public DateTime StartRequestTime { get; set; }
        public DateTime StartProcessTime { get; set; }
        public DateTime EndProcessTime { get; set; }
        public Machine Machine { get; set; }
        public bool isSuccess { get; set; }
        public bool needRestart { get; set; }
        public ProcessChild restartableProcess { get; set; }
    }
}
