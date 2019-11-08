using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.EF;
using SharedLibrary.Models.Entities;
using SharedLibrary.Models.ViewModels;

namespace DataAccessLayer.Repository
{
    public class LeaveRepository : ILeaveRepository
    {
        private readonly VacationPracticeDbContext _dbContext;

        public LeaveRepository(VacationPracticeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<SearchEmployeeResultViewModel> SearchEmployee(string keyword)
        {
            return _dbContext.Employees.Where(e => e.Name.Contains(keyword))
                             .Select(e => new SearchEmployeeResultViewModel
                                          {
                                              Id = e.Id,
                                              Name = e.Name
                                          });
        }

        public void Add(Leave employeeAddViewModel)
        {
            _dbContext.Leaves.Add(employeeAddViewModel);
            _dbContext.SaveChanges();
        }
    }
}