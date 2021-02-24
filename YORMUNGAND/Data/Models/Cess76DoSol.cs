using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class Cess76DoSol
    {
        private readonly AppDBContent appDBContent;
        public Cess76DoSol(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public void AddToCart(QueueItemID queueItemID)
        {
            //this.appDBContent.QueueItemIDs.Add(new QueueItemID { QID = queueItemID.QID + "TEST123"});
            appDBContent.SaveChanges();
        }
    }
}
