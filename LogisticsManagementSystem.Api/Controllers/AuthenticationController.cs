using LogisticsManagementSystem.Application;
using LogisticsManagementSystem.Contract;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsManagementSystem.Api;

[Route("auth")]
public class AuthenticationController(ISender _mediator) : ApiController
{
    [HttpPost("create")]
    public async Task<IActionResult> CreateEmployee(CreateEmployeeRequest request)
    {
        var command = new SetEmployeeCommand(request.userName, request?.phoneNumber, request.password);
        var result = await _mediator.Send(command);
        return result.Match(
            _ => NoContent(),
            Problem);
    }
}
