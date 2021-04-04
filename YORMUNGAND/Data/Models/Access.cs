using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data.Repository;
using YORMUNGAND.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace YORMUNGAND.Data.Models
{
    public class Access
    {
        public static void IniUser(IServiceProvider services)
        {
            //Проверить есть ли такой юзер в базе, если нет то добавить
            var context = services.GetService<AppDBContent>();
            var _user = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.User.Identity.Name;

            var user = context.AccessUsers.FirstOrDefault(i => i.USER == _user);
            var listrole = new List<AccessRole>();
            listrole.Add(context.AccessRole.FirstOrDefault(i => i.ROLE == "INDEEC"));
            if (!(user != null))
            {
                context.AccessUsers.Add(new AccessUsers
                {
                    USER = _user,
                    ACCESSROLE = listrole
                });

                
                context.SaveChanges();
            }
        }
        
    }
}
