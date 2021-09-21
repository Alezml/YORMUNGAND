using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VALHALLA.Data.Models
{
    public class HR_REPORT_CHATBOT_MAIN_FS
    {
        public int page { set; get; }
        public int pagesize { set; get; }
        public int count { set; get; }
        public int countTotal { set; get; }
        public IEnumerable<HR_REPORT_CHATBOT_MAIN> data { set; get; }
        public int id { set; get; }

        //public DateTime REQUEST_DATE { set; get; }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        //[DataType(DataType.Date)]
        public DateTime REQUEST_DATEfrom { set; get; }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        //[DataType(DataType.Date)]
        public DateTime REQUEST_DATEto { set; get; }

        [MaxLength(31)]
        public string SESSION_ID { set; get; }

        public int CONVERSATION_ID { set; get; }

        [MaxLength(63)]
        public string UD_EMPLOYEE_N { set; get; }

        [MaxLength(63)]
        public string UD_FULL_NAME { set; get; }

        public int PROCESSING_STATUS { set; get; }

        //public DateTime FINISH_DATE { set; get; }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        //[DataType(DataType.Date)]
        public DateTime FINISH_DATEfrom { set; get; }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        //[DataType(DataType.Date)]
        public DateTime FINISH_DATEto { set; get; }

        [MaxLength(31)]
        public string HR_DOMAIN_NAME { set; get; }

        [MaxLength(63)]
        public string HR_FULLNAME { set; get; }

        [MaxLength(31)]
        public string HR_MAIL { set; get; }

        public HR_REPORT_CHATBOT_MAIN_FS()
        {
            this.pagesize = 10;
            this.page = 1;
            this.REQUEST_DATEto = DateTime.Now.AddDays(1); // DateTime.Now;
            this.REQUEST_DATEfrom = new DateTime(2021, 1, 1); // new DateTime(2020, 1, 1);
            this.FINISH_DATEto = DateTime.Now.AddDays(1); // DateTime.Now;
        }
    }
}
