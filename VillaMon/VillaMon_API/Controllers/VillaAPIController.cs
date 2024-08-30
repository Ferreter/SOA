using Microsoft.AspNetCore.Mvc;
using VillaMon_API.Data;
using VillaMon_API.Models;

namespace VillaMon_API.Controllers
{
    
    [ApiController]
    [Route("api/VillaAPI")]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaList);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            if (id == null)
            {
                return BadRequest("Villa not found");
            }
            if (villa == null)
            {
                return NotFound();
            }

            return Ok(villa);
        }
    }
}
