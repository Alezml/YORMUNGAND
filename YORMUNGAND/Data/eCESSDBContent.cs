using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;

namespace YORMUNGAND.Data
{
    
    public class eCESSDBContent : DbContext
    {
        public eCESSDBContent(DbContextOptions<eCESSDBContent> options) : base(options)
        {

        }
        public DbSet<VIRCommentAnalitics> CESSVIRCOMMENTS { get; set; }

    }
}
