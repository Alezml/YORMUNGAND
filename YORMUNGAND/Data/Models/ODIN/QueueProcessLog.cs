using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class QueueProcessLog
    {
        private string id { get; set; }
        private QueueProcesses queueProcessesId { get; set; }
        private DateTime StartRequestTime { get; set; }
        private DateTime StartProcessTime { get; set; }
        private DateTime EndProcessTime { get; set; }
        private Machine Machine { get; set; }
        private bool isSuccess { get; set; }
        private bool needRestart { get; set; }
        private ProcessChild restartableProcess { get; set; }
    }
}
