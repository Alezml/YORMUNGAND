using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.ViewModels
{
    public class IdsListViewModel
    {
        public IEnumerable<QueueItemID> AllIds { get; set; }
        public IEnumerable<QueueItemID> NewIds { get; set; }
        public IEnumerable<QueueItemID> AcceptedIds { get; set; }
        public IEnumerable<QueueItemID> FinishedIds { get; set; }

        
    }
}
