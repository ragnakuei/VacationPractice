using SharedLibrary.Models.Entities;

namespace DataAccessLayer
{
    public interface IEmployeeRepository
    {
        void Add(Employee entity);
    }
}