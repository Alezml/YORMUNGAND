using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.ViewModels
{
    public class IdsListViewModel
    {
        public IEnumerable<QueueItemID> allIds { get; set; }
        public byte ShowType { get; set; }
    }
}
