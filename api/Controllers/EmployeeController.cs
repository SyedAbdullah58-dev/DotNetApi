using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase


    {
        private readonly DataContext _dbContext;

        public EmployeeController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }



        [HttpGet]  
        public async Task<ActionResult<List<Employee>>> Get() {
            return Ok(await _dbContext.employees.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<String>> Post(CreateEmployeeDto createEmployee)
        {
            var dep = await _dbContext.departments.FindAsync(createEmployee.DepartmentId);
            if (dep == null)
                return NotFound();
            var newEmployee = new Employee
            {
                Id = createEmployee.Id,
                Name = createEmployee.Name,
                Department = dep
            };

            _dbContext.employees.Add(newEmployee);
            await _dbContext.SaveChangesAsync();
            return Ok("added Safely");
        }
        [HttpPut]
        public async Task<ActionResult<Employee>> Put(Employee employee) {

            var emp = await _dbContext.employees.FindAsync(employee.Id);
            if (emp == null)
                return BadRequest(employee.Id + "not found");
            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Date    = employee.Date;
            emp.Department = employee.Department;
            _dbContext.employees.Add(emp);
            await _dbContext.SaveChangesAsync();
            return Ok(await _dbContext.employees.ToListAsync());
        }

    }
}
