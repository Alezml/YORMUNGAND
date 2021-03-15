using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class AccessRole
    {
        public int id { set; get; }
        public string ROLE { set; get; }
        public string DESC { set; get; }
        public virtual List<AccessUsers> ACCESSUSERS { set; get; }
        public virtual List<AccessPermissions> ACCESSPERMISSIONS { set; get; }


    }
}
