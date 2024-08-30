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
            if (villa == null)
            {
                return NotFound();
            }

            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ActionResult<VillaDTO> CreateVilla(VillaDTO villaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (villaDto == null)
            {
                return BadRequest("Villa is null");
            }
            if (villaDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            // Check if the name already exists
            if (VillaStore.villaList.Any(v => v.Name.ToLower() == villaDto.Name.ToLower()))
            {
                return BadRequest("Villa name already exists");
            }

            villaDto.Id = VillaStore.villaList.OrderByDescending(v => v.Id).FirstOrDefault().Id + 1;
            VillaStore.villaList.Add(villaDto);

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
                return BadRequest("Invalid villa id");
            }
            if (villa == null)
            {
                return NotFound();
            }

            VillaStore.villaList.Remove(villa);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]

        public ActionResult<VillaDTO> UpdateVilla(int id, VillaDTO updatedVillaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingVilla = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            if (existingVilla == null)
            {
                return NotFound();
            }

            // Check if the updated name already exists
            if (VillaStore.villaList.Any(v => v.Name.ToLower() == updatedVillaDto.Name.ToLower() && v.Id != id))
            {
                return BadRequest("Villa name already exists");
            }

            existingVilla.Name = updatedVillaDto.Name;
            existingVilla.Occupancy = updatedVillaDto.Occupancy;
            existingVilla.Sqft = updatedVillaDto.Sqft;


            return Ok(existingVilla);
        }



        [HttpPatch("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<VillaDTO> UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDocument)
        {
            var existingVilla = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            if (existingVilla == null)
            {
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
                return BadRequest(ModelState);
            }

            // Check if the updated name already exists
            if (VillaStore.villaList.Any(v => v.Name.ToLower() == villaToPatch.Name.ToLower() && v.Id != id))
            {
                return BadRequest("Villa name already exists");
            }

            existingVilla.Name = villaToPatch.Name;
            existingVilla.Occupancy = villaToPatch.Occupancy;
            existingVilla.Sqft = villaToPatch.Sqft;

            return Ok(existingVilla);
        }






    }
}
