using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext (DbContextOptions<WebAppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<WebApp.Models.Alan> Alan { get; set; }

        public DbSet<WebApp.Models.Kullanici> Kullanici { get; set; }
    }
}
