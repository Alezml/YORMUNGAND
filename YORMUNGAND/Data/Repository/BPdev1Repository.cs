using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.Data.Models.ODIN;
using System.Text.RegularExpressions;

namespace YORMUNGAND.Data.Repository
{
    public class BPdev1Repository
    {
        private readonly BPdev1DBContent bpdev1DBContent;
        public BPdev1Repository(BPdev1DBContent bpdev1DBContent)
        {
            this.bpdev1DBContent = bpdev1DBContent;
        }
        public IEnumerable<BPAProcess> GetAllApprovedProcess()
        {
            return bpdev1DBContent.BPAProcess.Where(p => p.AttributeID == 2 && p.ProcessType == "P" && EF.Functions.Like(p.description, "%#ODIN_APPROVED%"));
        }
    }
}

