
using Microsoft.EntityFrameworkCore;
using mvcmovie.Models;

namespace mvcmovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person {get;set;}
    }
}