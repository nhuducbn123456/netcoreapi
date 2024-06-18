using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NND_BT2324.Models;
using NND_BT2324.Models.Student;

namespace NND_BT2324.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NND_BT2324.Models.Person> Person { get; set; } = default!;
        public DbSet<NND_BT2324.Models.Student.Employee> Employee { get; set; } = default!;
    }
}
