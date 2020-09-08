using MediatR;

namespace HexagonalArchitecture.Application.Commands.EmployeeCommands
{
    public class AddEmployeeCommand : IRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }
    }
}
