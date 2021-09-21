using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VALHALLA.Data.Models
{
    public class HR_REPORT_CHATBOT_ROWS
    {
        public int id { set; get; }

        [MaxLength(63)]
        public string REPORT_HDR { set; get; }

        [MaxLength(63)]
        public string R_DATA { set; get; }

        public HR_REPORT_CHATBOT_MAIN REPORT_MAIN { set; get; }
    }
}
