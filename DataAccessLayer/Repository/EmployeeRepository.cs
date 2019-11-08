using System.Linq;
using DataAccessLayer.EF;
using SharedLibrary.Models.Entities;

namespace DataAccessLayer.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly VacationPracticeDbContext _dbContext;

        public EmployeeRepository(VacationPracticeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Employee entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }
    }
}