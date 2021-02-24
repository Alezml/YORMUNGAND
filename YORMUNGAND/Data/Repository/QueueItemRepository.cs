using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class QueueItemRepository : IALLids
    {
        private readonly AppDBContent appDBContent;
        public QueueItemRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<QueueItemID> QueueItems => appDBContent.QueueItemIDs.Include(c => c.CESS76INT);
    }
}
