using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data.Repository;

namespace YORMUNGAND.Data.Models
{
    public class Access
    {
        private AccessToolsRepository _atrep;
        private readonly AppDBContent appDBContent;
        public Access(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public void IniUser(string _user)
        {
            //this.appDBContent.QueueItemIDs.Add(new QueueItemID { QID = queueItemID.QID + "TEST123"});
            // Проверить есть ли такой юзер в базе, если нет то добавить
            var user = _atrep.Users.FirstOrDefault(i => i.USER == _user);
            if (user != null)
            {
            }
            else
            {
                this.appDBContent.AccessUsers.Add(new AccessUsers
                {
                    USER = _user
                });
                appDBContent.SaveChanges();
            }
                

        }
    }
}
