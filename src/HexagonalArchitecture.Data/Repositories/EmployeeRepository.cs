using HexagonalArchitecture.Application.Aggregates.EmployeeAggregate;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexagonalArchitecture.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IMongoDatabase database) 
            : base(database, "employees")
        {
        }

        public async Task<IEnumerable<Employee>> GetAsync()
        {
            var employees = await _collection.Find(_ => true).ToListAsync();
            return employees;
        }

        public async Task AddAsync(Employee employee)
        {
            await _collection.InsertOneAsync(employee);
        }
    }
}
