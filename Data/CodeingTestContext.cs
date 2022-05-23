using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeingTest.Models;

namespace CodeingTest.Data
{
    public class CodeingTestContext : DbContext
    {
        public CodeingTestContext (DbContextOptions<CodeingTestContext> options)
            : base(options)
        {
        }

        public DbSet<CodeingTest.Models.Employee>? Employee { get; set; }
    }
}
