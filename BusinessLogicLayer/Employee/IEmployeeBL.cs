using SharedLibrary.Models.ViewModels;

namespace BusinessLogicLayer.Employee
{
    public interface IEmployeeBL
    {
        void Add(EmployeeAddViewModel employeeAddViewModel);
    }
}