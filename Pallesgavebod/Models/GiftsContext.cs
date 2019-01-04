using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pallesgavebod.Models
{
    public class GiftsContext : DbContext
    {
        public DbSet<Gift> Gifts { get; set; }

        //public DbSet<> { get; set; }

        public GiftsContext(DbContextOptions<GiftsContext>options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
