using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab21_25Final.Models;

namespace Lab21_25Final.Data
{
    public class Lab21_25FinalContext : DbContext
    {
        public Lab21_25FinalContext (DbContextOptions<Lab21_25FinalContext> options)
            : base(options)
        {
        }

        public DbSet<Lab21_25Final.Models.Movie> Movie { get; set; }
    }
}
