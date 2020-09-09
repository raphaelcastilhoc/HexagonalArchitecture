using HexagonalArchitecture.Application.Commands.EmployeeCommands;
using HexagonalArchitecture.Application.Queries.EmployeeQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace HexagonalArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> Post(AddEmployeeCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GetEmployeesQueryResult>), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Get([FromQuery] GetEmployeesQuery query)
        {
            var employees = await _mediator.Send(query);

            if(employees == null || !employees.Any())
            {
                return NotFound();
            }

            return Ok(employees);
        }
    }
}
