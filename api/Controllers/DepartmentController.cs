using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public DepartmentController(DataContext context)
        {
            _dataContext = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Department>>> Get()
        {
            return
                    Ok(await _dataContext.departments.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<Department>> Post(Department department)
        {
            _dataContext.departments.Add(department);
        await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.departments.ToListAsync());
        }

       


    }
}
