using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class VBAlog
    {
        public int id { set; get; }
        public int VBAprojectID { set; get; }
        public string CompName { set; get; }
        public double VER { set; get; }
        public DateTime StartTime { set; get; }
    }
}
