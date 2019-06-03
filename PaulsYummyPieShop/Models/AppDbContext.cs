using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaulsYummyPieShop.Models
{
    /// <summary>
    /// The DbContext type passes data between our code and the database.
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        //We put our table types below.
        public DbSet<Pie> Pies { get; set; } 
    }
}
