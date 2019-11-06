using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models.Entities;

namespace DataAccessLayer.EF
{
    public class VacationPracticeDbContext : DbContext
    {
        public VacationPracticeDbContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}