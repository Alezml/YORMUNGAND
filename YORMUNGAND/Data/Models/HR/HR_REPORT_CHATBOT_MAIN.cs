using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VALHALLA.Data.Models
{
    public class HR_REPORT_CHATBOT_MAIN
    {
        public int id { set; get; }

        public DateTime REQUEST_DATE { set; get; }

        [MaxLength(31)]
        public string SESSION_ID { set; get; }

        public int CONVERSATION_ID { set; get; }

        [MaxLength(63)]
        public string UD_EMPLOYEE_N { set; get; }

        [MaxLength(63)]
        public string UD_FULL_NAME { set; get; }

        public int PROCESSING_STATUS { set; get; }

        public DateTime FINISH_DATE { set; get; }

        [MaxLength(31)]
        public string HR_DOMAIN_NAME { set; get; }

        [MaxLength(63)]
        public string HR_FULLNAME { set; get; }

        [MaxLength(31)]
        public string HR_MAIL { set; get; }

        public List<HR_REPORT_CHATBOT_ROWS> REPORT_ROWS { set; get; }
    }
}
