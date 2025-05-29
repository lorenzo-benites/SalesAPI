using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesAPI.Models;

namespace SalesAPI.Data
{
    public class SalesAPIContext : DbContext
    {
        public SalesAPIContext (DbContextOptions<SalesAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SalesAPI.Models.Department> Department { get; set; }
    }
}
