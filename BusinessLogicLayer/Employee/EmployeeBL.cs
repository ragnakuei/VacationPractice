using DataAccessLayer;
using SharedLibrary.Models.ViewModels;

namespace BusinessLogicLayer.Employee
{
    public class EmployeeBL : IEmployeeBL
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeBL(IEmployeeRepository employeeRepository)
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