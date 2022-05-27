using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodingTest.Models;

namespace CodingTest.Data
{
    public class CodingTestContext : DbContext
    {
        public CodingTestContext (DbContextOptions<CodingTestContext> options)
            : base(options)
        {
        }

        public DbSet<CodingTest.Models.Employee>? Employee { get; set; }
    }
}
