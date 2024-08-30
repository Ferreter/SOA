using Microsoft.AspNetCore.Mvc;
using VillaMon_API.Models;

namespace VillaMon_API.Controllers
{
    
    [ApiController]
    [Route("api/VillaAPI")]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas() {
            return new List<Villa> {
                new Villa { Id = 1, Name = "Villa 1" },
                new Villa { Id = 2, Name = "Villa 2" },
                new Villa { Id = 3, Name = "Villa 3" }
            };
        }

    }
}
