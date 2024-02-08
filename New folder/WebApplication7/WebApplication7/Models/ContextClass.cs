using Microsoft.EntityFrameworkCore;

namespace WebApplication7.Models
{
    public class ContextClass:DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }

    }
}
