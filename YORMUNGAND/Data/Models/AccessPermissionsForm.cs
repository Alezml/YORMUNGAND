using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class AccessPermissionsForm
    {
        public string PERMISSION { set; get; }
        public string DESC { set; get; }
        public virtual IEnumerable<AccessPermissions> ACCESSPERMISSIONS { set; get; }
    }
}
