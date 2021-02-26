using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class AccessUserRole
    {
        public int id { set; get; }
        public int ACCESSUSERS_REF { set; get; }
        public int ACCESSROLE_REF { set; get; }
        public virtual List<AccessUsers> ACCESSUSERS { set; get; }
        public virtual List<AccessRole> ACCESSROLE { set; get; }
    }
}