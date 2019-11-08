using System.Collections.Generic;
using SharedLibrary.Models.Entities;
using SharedLibrary.Models.ViewModels;

namespace DataAccessLayer.Repository
{
    public interface ILeaveRepository
    {
        IEnumerable<SearchEmployeeResultViewModel> SearchEmployee(string keyword);

        void Add(Leave employeeAddViewModel);
    }
}