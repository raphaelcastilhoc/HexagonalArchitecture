using HexagonalArchitecture.Application.Aggregates.EmployeeAggregate;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HexagonalArchitecture.Application.Commands.EmployeeCommands
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public AddEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Unit> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee(request.FirstName, request.LastName, request.Salary);
            await _employeeRepository.AddAsync(employee);

            return Unit.Value;
        }
    }
}
