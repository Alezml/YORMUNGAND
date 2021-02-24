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
        public virtual AccessUserRole ACCESSUSERROLE { set; get; }


}
}
