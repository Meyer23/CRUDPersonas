using APIWeb.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIWeb.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonaController : Controller
    {
        private readonly IPersonaRepository _repo; 
        public PersonaController(IPersonaRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Get()
        {
            var personas = await _repo.GetPersonas();
            return Ok(personas); 
        }
    }
}
