using System.Linq;
using DataAccessLayer.Repository;
using SharedLibrary.Models.ViewModels;

namespace BusinessLogicLayer.Leave
{
    public class LeaveService : ILeaveService
    {
        private readonly ILeaveRepository _leaveRepository;

        public LeaveService(ILeaveRepository leaveRepository)
        {
            _leaveRepository = leaveRepository;
        }
        
        public void Add(LeaveAddViewModel employeeAddViewModel)
        {
            var entity = new SharedLibrary.Models.Entities.Leave
                         {
                             EmployeeId = employeeAddViewModel.EmployeeId,
                             Kind = employeeAddViewModel.Kind,
                             LeaveStart = employeeAddViewModel.LeaveStart,
                             LeaveEnd = employeeAddViewModel.LeaveEnd,
                             LeaveTime = employeeAddViewModel.LeaveTime,
                             Reason = employeeAddViewModel.Reason, 
                         };
            _leaveRepository.Add(entity);
        }

        public SearchEmployeeResultViewModel[] SearchEmployee(string keyword)
        {
            return _leaveRepository.SearchEmployee(keyword).ToArray();
        }
    }
}