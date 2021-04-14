using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class UserAgentLog
    {
        public int id { set; get; }
        public string USERAGENT { set; get; }
        public string USERNAME { set; get; }
        public DateTime LOGDATE { set; get; }

    }
}
