using MediatR;
using System.Collections.Generic;

namespace HexagonalArchitecture.Application.Queries.EmployeeQueries
{
    public class GetEmployeesQuery : IRequest<IEnumerable<GetEmployeesQueryResult>>
    {
    }

    public class GetEmployeesQueryResult
    {
        public string Name { get; set; }

        public decimal Salary { get; set; }
    }
}
