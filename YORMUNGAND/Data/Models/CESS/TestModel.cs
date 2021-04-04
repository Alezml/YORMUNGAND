using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Year { get; set; }
    }
}
