using ExpertFinderRct.Services.ExpertServices;
using Microsoft.AspNetCore.Mvc;

namespace ExpertFinderRct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ExpertController : ControllerBase
    {
        private readonly IExpertService _expertService;

        public ExpertController(IExpertService expertService)
        {
            _expertService = expertService;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Expert>>> GetAllHeroes()
        {
            var result = await _expertService.GetExperts();
            if (result is null)
                return NotFound("No Experts found");

            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Expert>>? GetSingleExpert(int id)
        {
            var result = await _expertService.GetSingleExpert(id);

            if (result is null)
                return NotFound("Expert not found");

            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult<Expert>> AddExpert(Expert expert)
        {
            var result = await _expertService.AddExpert(expert);
            return Ok(result);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Expert>>? UpdateHero(int id, Expert expert)
        {
            var result = await _expertService.UpdateExpert(id, expert);
            if(result is null)
                return NotFound("Expert not found");
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Expert>>? DeleteExpert(int id)
        {
            var result = await _expertService.DeleteExpert(id);
            if (result is null)
                return NotFound("Expert not found");

            return Ok(result);
        }
    }
}
