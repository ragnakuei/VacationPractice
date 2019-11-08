using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repository;
using SharedLibrary.Models.ViewModels;

namespace BusinessLogicLayer.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        
        public void Add(EmployeeAddViewModel employeeAddViewModel)
        {
            var entity = new SharedLibrary.Models.Entities.Employee
                         {
                             Name = employeeAddViewModel.Name,
                             OnBoardDate = employeeAddViewModel.OnBoardDate,
                             BirthDay = employeeAddViewModel.BirthDay,
                             Phone = employeeAddViewModel.Phone, 
                         };
            _employeeRepository.Add(entity);
        }
    }
}