using ErrorOr;
using LogisticsManagementSystem.Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsManagementSystem.Api;

[Route("api/auth")]
public class AuthController(ISender _sender) : ApiController
{
    [HttpPost("login")]
    public async Task<IActionResult> LoginByUserName([FromBody] EmployeeLoginCommand command)
    {
        var result = await _sender.Send(command);
        return await result.Match(
            async employeeInfo =>
            {
                // 处理成功的逻辑
                var generateTokenQuery = new GenerateTokenQuery(employeeInfo.Employee, employeeInfo.Roles);
                var tokenResult = await _sender.Send(generateTokenQuery);
                return tokenResult.Match(
                    token => Ok(token),
                    errors => Problem(errors));
            },
          async errors => Problem(errors));
    }


    [HttpPost("generate-token")]
    public async Task<IActionResult> GenerateToken([FromBody] GenerateTokenQuery query)
    {
        var result = await _sender.Send(query);
        return result.Match(
        token => Ok(new { Token = token }),
        Problem);
    }



    [HttpPost("register")]
    public async Task<IActionResult> CreateEmployee(CreateEmployeeCommand command)
    {
        var result = await _sender.Send(command);
        return result.Match(
            _ => NoContent(),
            Problem);
    }
}
