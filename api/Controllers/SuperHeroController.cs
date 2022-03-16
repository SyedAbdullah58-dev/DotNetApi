using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
       
        private readonly DataContext context;

        public SuperHeroController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {

            return Ok(await context.superHeroes.ToListAsync());

        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> addHero(SuperHero hero)
        {
            context.superHeroes.Add(hero);
            await context.SaveChangesAsync();
            return Ok(await context.superHeroes.ToListAsync());

        }
     /*   [HttpGet("{id}")]
    *//*    public async Task<ActionResult<List<SuperHero>>> Get(int id)
        {
            var theHero = heroes.Find(h => h.Id == id);
            if (theHero == null)
            {
                return BadRequest("hero not found ");
            }*//*

            return Ok(theHero);
        }*/

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
         var dbhero=await context.superHeroes.FindAsync(id);
            if (dbhero == null)
                return BadRequest("not found");
            context.superHeroes.Remove(dbhero);
            context.SaveChangesAsync(); 
            return Ok(await context.superHeroes.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> Put(SuperHero request) {
         
        var hero=await context.superHeroes.FindAsync(request.Id);
            if (hero == null)
                return BadRequest(request.Id + "not found");
            hero.Name = request.Name;
           hero.LastName = request.LastName;
            hero.FirstName = request.FirstName;
            hero.Description = request.Description;

            await context.SaveChangesAsync();
            return Ok(await context.superHeroes.ToListAsync());
        
        }

    }
}

