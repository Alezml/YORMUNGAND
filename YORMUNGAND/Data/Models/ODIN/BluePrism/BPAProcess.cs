using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class BPAProcess
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid processid { get; set; }
        public string ProcessType { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int AttributeID { get; set; }
    }
}
