using SharedLibrary.Models.ViewModels;

namespace BusinessLogicLayer.Leave
{
    public interface ILeaveService
    {
        void Add(LeaveAddViewModel employeeAddViewModel);
        SearchEmployeeResultViewModel[] SearchEmployee(string keyword);
    }
}