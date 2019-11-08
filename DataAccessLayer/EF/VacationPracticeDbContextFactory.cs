using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataAccessLayer.EF
{
    public class VacationPracticeDbContextFactory : IDesignTimeDbContextFactory<VacationPracticeDbContext>
    {
        public VacationPracticeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VacationPracticeDbContext>();
            optionsBuilder.UseSqlServer("Server=.\\mssql2017;Database=VacationPractice;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new VacationPracticeDbContext(optionsBuilder.Options);
        }
    }
}