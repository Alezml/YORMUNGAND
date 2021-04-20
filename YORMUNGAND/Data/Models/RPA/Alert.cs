using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data.Repository;
using YORMUNGAND.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace YORMUNGAND.Data.Models
{
    public class Alert
    {
        public int id { set; get; }
        public string PROCES { set; get; }
        public string TAG { set; get; }
        public string ERROR_MSG { set; get; }
        public string DOLIST { set; get; }
        public DateTime EVENT_TIME { set; get; }
        public bool WORKED { set; get; }
        public DateTime WORKED_TIME { set; get; }
        virtual public string Blink { set; get; }
    }
}
