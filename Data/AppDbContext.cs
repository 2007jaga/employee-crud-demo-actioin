using Microsoft.EntityFrameworkCore;
using EmployeeCrudDemoAction;
using EmployeeCrudDemoAction.Models;
namespace EmployeeCrudDemoAction.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees => Set<Employee>();
    }
}