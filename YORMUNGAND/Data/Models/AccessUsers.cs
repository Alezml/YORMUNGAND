﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class AccessUsers
    {
        public int id { set; get; }
        public string USER { set; get; }
        public string NAME { set; get; }
        public string MAIL { set; get; }
        public DateTime DATE_REG { set; get; }
        public DateTime DATE_LAST_SEEN { set; get; }
        public virtual List<AccessRole> ACCESSROLE { set; get; }
    }
}
