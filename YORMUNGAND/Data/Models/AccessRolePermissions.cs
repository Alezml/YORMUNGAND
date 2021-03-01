using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class AccessRolePermissions
    {
        public int id { set; get; }
        public virtual AccessRole ACCESSROLE { set; get; }
        public virtual AccessPermissions ACCESSPERMISSIONS { set; get; }
    }
}
