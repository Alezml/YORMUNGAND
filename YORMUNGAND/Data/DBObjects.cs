using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {



            //if (!content.AccessPermissions.Any()) AccessRole AccessPermissions
            //    content.AccessPermissions.AddRange(Categories.Select(c => c.Value));

            if (!content.AccessRole.Any())
            {
                var PermList = new List<AccessPermissions>();
                PermList.Add(new AccessPermissions() { PERMISSION = "BaseRight", DESC = "Базовые права" });
                content.AddRange(
                    new AccessRole
                    {
                        ROLE = "INDEEC",
                        DESC = "Базовые права",
                        ACCESSPERMISSIONS = PermList,
                    }
                );
            }
            content.SaveChanges();
        }
    }

}

