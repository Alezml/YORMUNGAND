using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class Cess76Int
    {
        public int id { set; get; }
        public string QID { set; get; }
        public string STATUS { set; get; }
        public string  RESPONSIBLE_FOR_CHOICE{ set; get; }
        public string CHOICE_STATUS { set; get; }
        public DateTime CHOICE_DATETIME { set; get; }
        public int QUEUEITEMID_REF { get; set; }
        public virtual QueueItemID QUEUEITEMID { get; set; }

    }
}
