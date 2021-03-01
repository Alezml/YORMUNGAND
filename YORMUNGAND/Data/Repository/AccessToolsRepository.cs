using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class AccessToolsRepository : IAccessTools
    {
        private readonly AppDBContent appDBContent;
        public AccessToolsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<AccessUsers> Users => appDBContent.AccessUsers.OrderBy(c => c.id);
    }
}
