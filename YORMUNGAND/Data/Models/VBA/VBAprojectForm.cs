﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class VBAprojectForm
    {
        public string NAME { set; get; }
        public string DESC { set; get; }
        public virtual IEnumerable<VBAproject> VBAPROJECTS { set; get; }
    }
}