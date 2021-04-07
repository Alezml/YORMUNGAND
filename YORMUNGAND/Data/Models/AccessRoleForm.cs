using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class AccessRoleForm
    {
        public string ROLE { set; get; }
        public string DESC { set; get; }
        public virtual IEnumerable<AccessRole> ACCESSROLE { set; get; }
    }
}
