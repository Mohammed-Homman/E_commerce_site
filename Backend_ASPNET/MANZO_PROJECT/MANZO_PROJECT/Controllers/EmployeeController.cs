// EmployeeController.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using MANZO_PROJECT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MANZO_PROJECT.Models;
using MANZO_PROJECT.Context;  // Make sure to replace "YourAppName" with the actual namespace of your application.

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public EmployeeController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("Get")]
    public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
    {
        var employees = await _dbContext.Employees.ToListAsync();
        return Ok(employees);
    }
}
