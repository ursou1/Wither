using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wither.Models
{
    public class KboardContext: DbContext
    {
        public DbSet<Kboard> Kboards { get; set; }
        public DbSet<Order> Orders { get; set; }

        public KboardContext(DbContextOptions<KboardContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
