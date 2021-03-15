﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class TestRepository : ITest
    {
        private readonly CESSDBContent appDBContent;
        public TestRepository(CESSDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<TestModel> TestModels => appDBContent.TEST.OrderBy(i => i.Test3);
    }
}
