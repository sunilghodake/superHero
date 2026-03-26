using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using superHero.Services;

namespace superHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroServices _superHeroServices;
       public SuperHeroController(ISuperHeroServices superHeroServices)
        {
            this._superHeroServices = superHeroServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            return Ok(await _superHeroServices.GetSuperHeroesAsync());
        } 
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSuperHeroesById(int id)
        {
           SuperHero?  superHero =await _superHeroServices.GetSuperHeroesByIdAsync(id);
            if (superHero == null)
                return NotFound("superHero not found for this id ");
            return Ok(superHero);
        }
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddSuperHeroes(SuperHero hero)
        {

            return Ok(await _superHeroServices.AddSuperHeroesAsync(hero));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateSuperHero(int id,SuperHero newHero)
        {
            var heroes = await _superHeroServices.UpdateSuperHeroAsync(id,newHero);
            if (heroes == null)
                return NotFound("superheroes not found for this id");
            return Ok(heroes);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteSuperHero(int id)
        {
            var heroes = await _superHeroServices.DeleteSuperHeroAsync(id);
            if (heroes == null)
                return NotFound("superHero not found for this id ");
          
           
            return Ok(heroes);
        }
    }
}
