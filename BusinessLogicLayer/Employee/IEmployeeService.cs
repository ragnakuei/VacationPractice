using SharedLibrary.Models.ViewModels;

namespace BusinessLogicLayer.Employee
{
    public interface IEmployeeService
    {
        void Add(EmployeeAddViewModel employeeAddViewModel);
    }
}