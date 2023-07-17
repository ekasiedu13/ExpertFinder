using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpertFinderRct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class InstitutionController : ControllerBase
    {
        [HttpGet]
        //public async Task<ActionResult<List<Expert>>> GetAllHeroes()
        public List<string> GetAllInstitutions()
        {
            List<string> Institutions = new List<string>() { "CSIR", "FDA", "GSA" };

            Console.WriteLine(Institutions);
            return Institutions;
        }
    }
}

