using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class AccessUsers
    {
        public int id { set; get; }
        public string USER { set; get; }
        public virtual AccessUserRole ACCESSUSERROLE { set; get; }
    }
}
