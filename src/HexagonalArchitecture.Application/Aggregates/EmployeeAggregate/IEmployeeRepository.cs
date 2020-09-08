using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexagonalArchitecture.Application.Aggregates.EmployeeAggregate
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAsync();

        Task AddAsync(Employee employee);
    }
}
