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
    public class ThreeString
    {
        public string one { get; set; }
        public string two { get; set; }
        public string three { get; set; }
    }
}
