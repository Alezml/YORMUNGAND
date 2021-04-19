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
    //Алерты для передачи во вью
    public class AlertView
    {
        public IEnumerable<Alert> ToDo { get; set; }
        public IEnumerable<Alert> Worked { get; set; }
    }
}
