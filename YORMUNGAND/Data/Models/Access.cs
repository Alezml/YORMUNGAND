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
        public static void IniUser(AccessToolsRepository _rep, string UserName)
        {
            //Проверить есть ли такой юзер в базе, если нет то добавить
            var user = _rep.GetUserByDomainName(UserName);
            
            if (user == null)
            {
                var listrole = new List<AccessRole>
                {
                    _rep.GetBaseRole("INDEEC") //context.AccessRole.FirstOrDefault(i => i.ROLE == "INDEEC")
                };
                _rep.AddNewUser(UserName, listrole);
            }
            else
            {
                if (user.DATE_LAST_SEEN.AddHours(1) < DateTime.Now)
                {
                    _rep.UpdateUserSeen(user);
                }
                
            }
        }
        public static string GetUserName(IServiceProvider services)
        {
            return services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.User.Identity.Name;
        }
        public static string IsAccess(IServiceProvider services, string prava)
        {
            var context = services.GetService<AppDBContent>();
            var _user = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.User.Identity.Name;
            string _userAgent = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Request.Headers["User-Agent"].ToString();
            var _rep = new AccessToolsRepository(context);

            IniUser(_rep, _user);
            LogUserAgent(_rep, _userAgent, _user);
            if (CheckAccess(_rep, _user, prava))
            {
                if (_userAgent.Contains("Chrome") || _userAgent.Contains("YaBrowser"))
                {
                    return "true";
                }
                else
                {
                    return "wrongagent";
                }
            }
            else
            {
                return "false";
            }
        }
        public static Boolean CheckAccess(AccessToolsRepository _rep, string UserName, string prava)
        {
            AccessUsers user = _rep.GetUserFullByDomainName(UserName);
            if (user == null)
            {
                return false;
            }
            else
            {
                foreach (AccessRole role in user.ACCESSROLE )
                {
                    if (role.ROLE == "SHERIFF")
                    {
                        return true;
                    }
                    foreach (AccessPermissions perm in role.ACCESSPERMISSIONS)
                        if (perm.PERMISSION == prava)
                        {
                            return true;
                        }
                }
            }
            return false;
        }
        public static void LogUserAgent(AccessToolsRepository _rep, string uaName, string userName)
        {
            _rep.AddUserAgentLog(uaName, userName);
        }
    }
}
