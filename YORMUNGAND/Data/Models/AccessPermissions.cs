﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class AccessPermissions
    {
        public int id { set; get; }
        public string PERMISSION { set; get; }
        public virtual AccessRole ACCESSROLE { set; get; }


    }
}