using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserDataApi.Data.Models
{
    //[BindNever]
    [Keyless]
    public class UserData
    {
        [Column("user_name")]
        public string user_name { get; set; }

        [Column("email_address")]
        public string email_address { get; set; }

        [Column("user_description")]
        public string user_description { get; set; }

        [Column("employee_number")]
        public string employee_number { get; set; }

        [Column("phonemobile")]
        public string phonemobile { get; set; }

        [Column("first_name")]
        public string first_name { get; set; }

        [Column("middle_names")]
        public string middle_names { get; set; }

        [Column("last_name")]
        public string last_name { get; set; }

        [Column("act")]
        public string act { get; set; }

        [Column("inner")]
        public string inner { get; set; }
    }
}
