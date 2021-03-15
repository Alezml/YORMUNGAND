using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    [Table("Test-Table")]
    [Keyless]
    public class TestModel
    {
        [Column("f")]
        public string  Test1 { set; get; }

        [Column("test-column")]
        public string Test2 { set; get; }
        //[Key]
        [Column("ключ")]
        public int Test3 { set; get; }
    }
}
