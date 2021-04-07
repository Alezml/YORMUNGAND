using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class AccessToolsRepository : IAccessTools
    {
        private readonly AppDBContent appDBContent;
        public AccessToolsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<AccessUsers> Users => appDBContent.AccessUsers.OrderBy(c => c.id);
        public IEnumerable<AccessUsers> User => appDBContent.AccessUsers.Include(c => c.ACCESSROLE).ThenInclude(r => r.ACCESSPERMISSIONS);

        public AccessUsers GetUserByDomainName(string _userName)
        {
            return appDBContent.AccessUsers.FirstOrDefault(i => i.USER == _userName);
        }
        public AccessUsers GetUserFullByDomainName(string _userName)
        {
            return appDBContent.AccessUsers.Include(c => c.ACCESSROLE).ThenInclude(r => r.ACCESSPERMISSIONS).FirstOrDefault(i => i.USER == _userName);
        }
        public AccessRole GetBaseRole(string role)
        {
            return appDBContent.AccessRole.FirstOrDefault(i => i.ROLE == role);
        }
        public void AddNewUser(string UserName, List<AccessRole> listrole)
        {
            appDBContent.AccessUsers.Add(new AccessUsers
            {
                USER = UserName,
                ACCESSROLE = listrole,
                DATE_REG = DateTime.Now,
                DATE_LAST_SEEN = DateTime.Now
            });
            appDBContent.SaveChanges();
        }
        public void UpdateUserSeen(AccessUsers user)
        {
            user.DATE_LAST_SEEN = DateTime.Now;
            appDBContent.SaveChanges();
        }
        public IEnumerable<AccessPermissions> GetAllPermissons()
        {
            return appDBContent.AccessPermissions.OrderByDescending(i => i.id);
        }
        // Получить список полномочий для 
        public IEnumerable<AccessPermissions> GetPermByRole(string role)
        {
            IEnumerable<AccessPermissions> _PermList = null;
            AccessRole _role = appDBContent.AccessRole.Include(r => r.ACCESSPERMISSIONS).FirstOrDefault(r => r.ROLE == role);
            if (_role != null)
            {
                _PermList = _role.ACCESSPERMISSIONS;
            }
            return _PermList;
        }
        public AccessPermissionsForm AddNewPermission(AccessPermissionsForm inptForm)
        {
            if (inptForm.PERMISSION == null || inptForm.PERMISSION.Replace(" ", "") == "" || inptForm.PERMISSION == "Имя не может быть пустым")
            {
                inptForm.PERMISSION = "Имя не может быть пустым";
            }
            else if (inptForm.DESC == null || inptForm.DESC.Replace(" ", "") == "" || inptForm.DESC == "Описание не может быть пустым")
            {
                inptForm.DESC = "Описание не может быть пустым";
            }
            else
            {
                AccessPermissions IsExists = appDBContent.AccessPermissions.FirstOrDefault(i => i.PERMISSION == inptForm.PERMISSION.Replace(" ", ""));
                if (IsExists == null)
                {
                    appDBContent.AccessPermissions.Add(new AccessPermissions
                    {
                        PERMISSION = inptForm.PERMISSION.Replace(" ", ""),
                        DESC = inptForm.DESC.Replace(" ", "")
                    });
                    appDBContent.SaveChanges();
                    inptForm.PERMISSION = "Добавлено успешно";
                    inptForm.DESC = "";
                }
                else
                {
                    inptForm.PERMISSION = "Имя занято";
                    inptForm.DESC = "";
                }
            }
            return inptForm;
        }
        //Добавление прав в роль
        public void AddPermToRole(string role, string perm)
        {
            AccessRole _role = appDBContent.AccessRole.Include(a => a.ACCESSPERMISSIONS).FirstOrDefault(a => a.ROLE == role);
            AccessPermissions _perm = appDBContent.AccessPermissions.FirstOrDefault(p => p.PERMISSION == perm);
            _role.ACCESSPERMISSIONS.Add(_perm);
            appDBContent.SaveChanges();
        }
        //Удаление прав из роли
        public void DeletePermFromRole(string role, string perm)
        {
            AccessRole _role = appDBContent.AccessRole.Include(a => a.ACCESSPERMISSIONS).FirstOrDefault(a => a.ROLE == role);
            AccessPermissions _perm = appDBContent.AccessPermissions.FirstOrDefault(p => p.PERMISSION == perm);
            _role.ACCESSPERMISSIONS.Remove(_perm);
            appDBContent.SaveChanges();
        }
        // Получить все роли
        public IEnumerable<AccessRole> GetAllRole()
        {
            return appDBContent.AccessRole.OrderByDescending(i => i.id);
        }
        // Добавить новую роль
        public AccessRoleForm AddNewRole(AccessRoleForm inptForm)
        {
            if (inptForm.ROLE == null || inptForm.ROLE.Replace(" ", "") == "" || inptForm.ROLE == "Имя не может быть пустым")
            {
                inptForm.ROLE = "Имя не может быть пустым";
            }
            else if(inptForm.DESC == null || inptForm.DESC.Replace(" ", "") == "" || inptForm.DESC == "Описание не может быть пустым")
            {
                inptForm.DESC = "Описание не может быть пустым";
            }
            else
            {
            AccessRole IsExists = appDBContent.AccessRole.FirstOrDefault(i => i.ROLE == inptForm.ROLE.Replace(" ", ""));
                if (IsExists == null)
                {
                    appDBContent.AccessRole.Add(new AccessRole
                    {
                        ROLE = inptForm.ROLE.Replace(" ", ""),
                        DESC = inptForm.DESC.Replace(" ", "")
                    });
                    appDBContent.SaveChanges();
                    inptForm.ROLE = "Добавлено успешно";
                    inptForm.DESC = "";
                }
                else
                {
                    inptForm.ROLE = "Имя занято";
                    inptForm.DESC = "";
                }
            }
            return inptForm;
        }

        public IEnumerable<ThreeString> GetPermByRoleAndOther(string role)
        {
            //получить список доступов роли
            IEnumerable<AccessPermissions> rolePerm = this.GetPermByRole(role);
            //получить список остальных доступов (не назначенных данной роли)
            IEnumerable<AccessPermissions> otherPerm = this.GetAllPermissons().Where(p => !this.GetPermByRole(role).Select(p => p.PERMISSION).ToList().Contains(p.PERMISSION));
            //формирование результата
            List<ThreeString> result = new List<ThreeString>();
            foreach (AccessPermissions _perm in rolePerm)
            {
                result.Add(new ThreeString { one = _perm.PERMISSION, two = _perm.DESC, three = "checked" });
            }
            foreach (AccessPermissions _perm in otherPerm)
            {
                result.Add(new ThreeString { one = _perm.PERMISSION, two = _perm.DESC, three = "" });
            }
            return result;
        }
        //получить описание доступа
        public string GetPermDesc(string perm)
        {
            return appDBContent.AccessPermissions.FirstOrDefault(p => p.PERMISSION == perm).DESC;
        }
        //получить описание роли
        public string GetRoleDesc(string role)
        {
            return appDBContent.AccessRole.FirstOrDefault(p => p.ROLE == role).DESC;
        }
        // Получить все роли
        public IEnumerable<AccessUsers> GetAllUsers()
        {
            return appDBContent.AccessUsers.OrderByDescending(i => i.id);
        }
        public IEnumerable<ThreeString> GetRoleByUserAndOther(string user)
        {
            //получить список ролей для пользователя
            IEnumerable<AccessRole> userRole = this.GetRoleByUser(user);
            //получить список остальных доступов (не назначенных данной роли)
            IEnumerable<AccessRole> otherRole = this.GetAllRole().Where(p => !this.GetRoleByUser(user).Select(p => p.ROLE).ToList().Contains(p.ROLE));
            //формирование результата
            List<ThreeString> result = new List<ThreeString>();
            foreach (AccessRole _role in userRole)
            {
                result.Add(new ThreeString { one = _role.ROLE, two = _role.DESC, three = "checked" });
            }
            foreach (AccessRole _role in otherRole)
            {
                result.Add(new ThreeString { one = _role.ROLE, two = _role.DESC, three = "" });
            }
            return result;
        }
        // Получить список ролей для пользователя
        public IEnumerable<AccessRole> GetRoleByUser(string user)
        {
            IEnumerable<AccessRole> _RoleList = null;
            AccessUsers _user = appDBContent.AccessUsers.Include(r => r.ACCESSROLE).FirstOrDefault(r => r.USER == user);
            if (_user != null)
            {
                _RoleList = _user.ACCESSROLE;
            }
            return _RoleList;
        }
        //Добавление ролей пользователю
        public void AddRoleToUser(string user, string role)
        {
            AccessUsers _user = appDBContent.AccessUsers.Include(a => a.ACCESSROLE).FirstOrDefault(a => a.USER == user);
            AccessRole _role = appDBContent.AccessRole.FirstOrDefault(p => p.ROLE == role);
            _user.ACCESSROLE.Add(_role);
            appDBContent.SaveChanges();
        }
        //Удаление 
        public void DeleteRoleFromUser(string user, string role)
        {
            AccessUsers _user = appDBContent.AccessUsers.Include(a => a.ACCESSROLE).FirstOrDefault(a => a.USER == user);
            AccessRole _role = appDBContent.AccessRole.FirstOrDefault(p => p.ROLE == role);
            _user.ACCESSROLE.Remove(_role);
            appDBContent.SaveChanges();
        }
    }
}

