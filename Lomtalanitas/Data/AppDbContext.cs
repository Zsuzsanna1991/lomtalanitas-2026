using Lomtalanitas.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Lomtalanitas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Korzet> Korzetek { get; set; }
        public DbSet<Utcanev> Utcanevek { get; set; }
    }
}