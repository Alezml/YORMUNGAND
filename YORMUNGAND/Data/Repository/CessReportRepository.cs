using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class CessReportRepository: ICessReport
    {
        private readonly CESSDBContent appDBContent;
        public CessReportRepository(CESSDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<MainReportWave1> MainReportWave1s { get; }
        public IEnumerable<MainReportWave1> MainReportWaves(int page, int pagesize) => 
            appDBContent.MAIN_1.OrderByDescending(i => i.VIR_DATE).Skip((page -1)* pagesize).Take(pagesize);
    }
}
