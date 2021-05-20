using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class StatistikCessReportDwnld
    {

        public int id { set; get; }
        public string USER { set; get; }
        public int ROWS_COUNT { set; get; }
        public DateTime EVENT_DATE { set; get; }
        
    }
}
