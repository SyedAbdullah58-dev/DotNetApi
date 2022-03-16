using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public ApplicantController(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Applicant>>> Get()
        {
            return Ok(await _dbContext.applicants.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<Applicant>>> Post(Applicant applicant)
        {
            _dbContext.applicants.AddAsync(applicant);
            await _dbContext.SaveChangesAsync();
            return Ok(await _dbContext.applicants.ToListAsync());

        }

     

    }
}
