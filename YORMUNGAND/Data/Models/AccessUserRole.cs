using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class AccessUserRole
    {
        public int id { set; get; }
        public virtual AccessUsers ACCESSUSERS { set; get; }
        public virtual AccessRole ACCESSROLE{ set; get; }


    }
}
