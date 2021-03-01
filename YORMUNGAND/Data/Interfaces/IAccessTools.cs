using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Interfaces
{
    public interface IAccessTools
    {

        IEnumerable<AccessUsers> Users { get; }
        //IEnumerable<AccessRole> AccessRole { get; set; }
        //IEnumerable<AccessUserRole> AccessUserRole { get; set; }
        //IEnumerable<AccessRolePermissions> AccessRolePermissions { get; set; }
        //IEnumerable<AccessPermissions> AccessPermissions { get; set; }

    }
}
