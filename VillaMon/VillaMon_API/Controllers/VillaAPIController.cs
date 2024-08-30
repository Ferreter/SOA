using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VillaMon_API.Data;
using VillaMon_API.Models.Dto;

namespace VillaMon_API.Controllers
{
    
    [ApiController]
    [Route("api/VillaAPI")]
    public class VillaAPIController : ControllerBase
    {
        private readonly ILogger<VillaAPIController> _logger;
        public VillaAPIController(ILogger<VillaAPIController> logger) {
            _logger = logger;

        }



        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            _logger.LogInformation("Getting all villas");
            return Ok(VillaStore.villaList);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            _logger.LogInformation($"Getting villa with id {id}");
            var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                _logger.LogWarning($"Villa with id {id} not found");
                return NotFound();
            }
            _logger.BeginScope($"Villa with id {id} found");
            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ActionResult<VillaDTO> CreateVilla(VillaDTO villaDto)
        {
            _logger.LogInformation("Creating a new villa");
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Model state is invalid");
                return BadRequest(ModelState);
            }

            if (villaDto == null)
            {
                _logger.LogWarning("Villa is null");
                return BadRequest("Villa is null");
            }
            if (villaDto.Id > 0)
            {
                _logger.LogWarning("Villa id is greater than 0");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            // Check if the name already exists
            if (VillaStore.villaList.Any(v => v.Name.ToLower() == villaDto.Name.ToLower()))
            {
                _logger.LogWarning("Villa name already exists");
                return BadRequest("Villa name already exists");
            }

            villaDto.Id = VillaStore.villaList.OrderByDescending(v => v.Id).FirstOrDefault().Id + 1;
            VillaStore.villaList.Add(villaDto);
            _logger.LogInformation($"Villa with id {villaDto.Id} created");
            return CreatedAtAction(nameof(GetVilla), new { id = villaDto.Id }, villaDto);
        }


        [HttpDelete("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult DeleteVilla(int id)
        {
            var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            if (id <= 0)
            {
                _logger.LogWarning("Invalid villa id");
                return BadRequest("Invalid villa id");
            }
            if (villa == null)
            {
                _logger.LogWarning($"Villa with id {id} not found");
                return NotFound();
            }

            VillaStore.villaList.Remove(villa);

            _logger.LogInformation($"Villa with id {id} deleted");
            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]

        public ActionResult<VillaDTO> UpdateVilla(int id, VillaDTO updatedVillaDto)
        {
            _logger.LogInformation($"Updating villa with id {id}");
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Model state is invalid");
                return BadRequest(ModelState);
            }

            var existingVilla = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            if (existingVilla == null)
            {
                _logger.LogWarning($"Villa with id {id} not found");
                return NotFound();
            }

            // Check if the updated name already exists
            if (VillaStore.villaList.Any(v => v.Name.ToLower() == updatedVillaDto.Name.ToLower() && v.Id != id))
            {
                _logger.LogWarning("Villa name already exists");
                return BadRequest("Villa name already exists");
            }

            existingVilla.Name = updatedVillaDto.Name;
            existingVilla.Occupancy = updatedVillaDto.Occupancy;
            existingVilla.Sqft = updatedVillaDto.Sqft;


            _logger.LogInformation($"Villa with id {id} updated");
            return Ok(existingVilla);
        }



        [HttpPatch("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]

        public ActionResult<VillaDTO> UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDocument)
        {
            _logger.LogInformation($"Updating partial villa with id {id}");
            var existingVilla = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            if (existingVilla == null)
            {
                _logger.LogWarning($"Villa with id {id} not found");
                return NotFound();
            }

            var villaToPatch = new VillaDTO
            {
                Id = existingVilla.Id,
                Name = existingVilla.Name,
                Occupancy = existingVilla.Occupancy,
                Sqft = existingVilla.Sqft
            };

            patchDocument.ApplyTo(villaToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Model state is invalid");
                return BadRequest(ModelState);
            }

            // Check if the updated name already exists
            if (VillaStore.villaList.Any(v => v.Name.ToLower() == villaToPatch.Name.ToLower() && v.Id != id))
            {_logger.LogWarning("Villa name already exists");
                return BadRequest("Villa name already exists");
            }

            existingVilla.Name = villaToPatch.Name;
            existingVilla.Occupancy = villaToPatch.Occupancy;
            existingVilla.Sqft = villaToPatch.Sqft;

            return Ok(existingVilla);
        }






    }
}
