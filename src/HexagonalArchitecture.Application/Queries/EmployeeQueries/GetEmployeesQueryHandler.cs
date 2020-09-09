using HexagonalArchitecture.Application.Aggregates.EmployeeAggregate;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HexagonalArchitecture.Application.Queries.EmployeeQueries
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, IEnumerable<GetEmployeesQueryResult>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeesQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<GetEmployeesQueryResult>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _employeeRepository.GetAsync();

            var employeesResult = new List<GetEmployeesQueryResult>(employees.Count());
            foreach (var employee in employees)
            {
                var employeeResult =  new GetEmployeesQueryResult
                {
                    Name = employee.Name,
                    Salary = employee.Salary
                };

                employeesResult.Add(employeeResult);
            }

            return employeesResult;
        }
    }
}
