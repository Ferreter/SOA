using Microsoft.AspNetCore.Mvc;
using VillaMon_API.Models;

namespace VillaMon_API.Controllers
{
    
    [ApiController]
    [Route("api/VillaAPI")]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas() {
            return 
        }

    }
}
