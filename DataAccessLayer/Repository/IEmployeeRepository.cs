using System.Collections.Generic;
using SharedLibrary.Models.Entities;
using SharedLibrary.Models.ViewModels;

namespace DataAccessLayer.Repository
{
    public interface IEmployeeRepository
    {
        void Add(Employee entity);
    }
}