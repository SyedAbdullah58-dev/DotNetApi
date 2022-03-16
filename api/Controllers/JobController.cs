using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public JobController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Job>>> Get()
        {
            return Ok(await _dataContext.jobs.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> PostJob([FromBody] Job job)
        {

            _dataContext.jobs.AddAsync(job);
           await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.jobs.ToListAsync());

        }
    }
}
