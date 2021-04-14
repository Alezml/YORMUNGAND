using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class CashBlock
    {
        public int id { set; get; }
        public bool BLOCKED { set; get; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime DATE { set; get; }
        public string BLOCK_NAME { set; get; }
        public DateTime BLOCK_DATE { set; get; }
    }
}
