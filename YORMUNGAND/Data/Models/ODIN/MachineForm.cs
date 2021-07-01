using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class MachineForm
    {
        public string machineName { get; set; }
        public virtual IEnumerable<Machine> MachineList { set; get; }
    }
}