using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Interfaces
{
    public interface ICessReport
    {

        IEnumerable<MainReportWave1> MainReportWave1 { get; }
    }
}
