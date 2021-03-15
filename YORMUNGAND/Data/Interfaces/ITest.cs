using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Interfaces
{
    public interface ITest
    {

        IEnumerable<TestModel> TestModels { get; }
    }
}
