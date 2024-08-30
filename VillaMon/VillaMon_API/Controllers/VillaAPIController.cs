using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using VillaMon_API.Data;
using VillaMon_API.Models;
using VillaMon_API.Models.Dto;

namespace VillaMon_API.Controllers
{
    
    [ApiController]
    [Route("api/VillaAPI")]
    public class VillaAPIController : ControllerBase
    {


        private readonly ApplicationDbContext _db;
        public VillaAPIController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet("ByOccupancy/{occupancy}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillasByOccupancy(int occupancy)
        {
            var villas = _db.Villas.Where(v => v.Occupancy >= occupancy).ToList();
            if (!villas.Any())
            {
                return NotFound("No villas found accommodating the specified number of occupants");
            }
            return Ok(villas);
        }

        [HttpGet("ByAmenity/{amenity}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillasByAmenity(string amenity)
        {
            var villas = _db.Villas.Where(v => v.Amenity.ToLower().Contains(amenity.ToLower())).ToList();
            if (!villas.Any())
            {
                return NotFound("No villas found with the specified amenity");
            }
            return Ok(villas);
        }
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
  
            return Ok(_db.Villas);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {

            var villa = _db.Villas.FirstOrDefault(v => v.Id == id);
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
            if (_db.Villas.Any(v => v.Name.ToLower() == villaDto.Name.ToLower()))
            {

                return BadRequest("Villa name already exists");
            }

            Villa model = new()
            {
                Name = villaDto.Name,
                Occupancy = villaDto.Occupancy,
                Sqft = villaDto.Sqft,
                Amenity = villaDto.Amenity,
                Details = villaDto.Details,
                ImageUrl = villaDto.ImageUrl,
                Rate = villaDto.Rate,
                Id = villaDto.Id,


    
            };

            _db.Villas.AddAsync(model);
            _db.SaveChanges();
            return CreatedAtAction(nameof(GetVilla), new { id = villaDto.Id }, villaDto);
        }


        [HttpDelete("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult DeleteVilla(int id)
        {
            var villa = _db.Villas.FirstOrDefault(v => v.Id == id);
            if (id <= 0)
            {
                return BadRequest("Invalid villa id");
            }
            if (villa == null)
            {
                return NotFound();
            }

            _db.Villas.Remove(villa);
            _db.SaveChanges();


            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]

        public ActionResult<VillaDTO> UpdateVilla(int id, VillaDTO villaDto)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }

            var existingVilla = _db.Villas.FirstOrDefault(v => v.Id == id);
            if (existingVilla == null)
            {

                return NotFound();
            }

            // Check if the updated name already exists
            if (_db.Villas.Any(v => v.Name.ToLower() == villaDto.Name.ToLower() && v.Id != id))
            {

                return BadRequest("Villa name already exists");
            }


            Villa model = new()
            {
                Name = villaDto.Name,
                Occupancy = villaDto.Occupancy,
                Sqft = villaDto.Sqft,
                Amenity = villaDto.Amenity,
                Details = villaDto.Details,
                ImageUrl = villaDto.ImageUrl,
                Rate = villaDto.Rate,
                Id = villaDto.Id,
            };

            _db.Villas.Update(model);
            _db.SaveChanges();


            return Ok(existingVilla);
        }



        //[HttpPatch("{id:int}")]
        //[ProducesResponseType(200)]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(404)]

        //public ActionResult<VillaDTO> UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDocument)
        //{
        //    _logger.LogInformation($"Updating partial villa with id {id}");
        //    var villaDto = _db.Villas.FirstOrDefault(v => v.Id == id);

        //    Villa model = new()
        //    {
        //        Name = villaDto.Name,
        //        Occupancy = villaDto.Occupancy,
        //        Sqft = villaDto.Sqft,
        //        Amenity = villaDto.Amenity,
        //        Details = villaDto.Details,
        //        ImageUrl = villaDto.ImageUrl,
        //        Rate = villaDto.Rate,
        //        Id = villaDto.Id,
        //    };

        //    if (villaDto == null)
        //    {
        //        _logger.LogWarning($"Villa with id {id} not found");
        //        return NotFound();
        //    }

        //    var villaToPatch = new VillaDTO
        //    {
        //        Id = villaDto.Id,
        //        Name = villaDto.Name,
        //        Occupancy = villaDto.Occupancy,
        //        Sqft = villaDto.Sqft
        //    };

        //    patchDocument.ApplyTo(villaToPatch, ModelState);

        //    if (!ModelState.IsValid)
        //    {
        //        _logger.LogWarning("Model state is invalid");
        //        return BadRequest(ModelState);
        //    }

        //    // Check if the updated name already exists
        //    if (_db.Villas.Any(v => v.Name.ToLower() == villaToPatch.Name.ToLower() && v.Id != id))
        //    {_logger.LogWarning("Villa name already exists");
        //        return BadRequest("Villa name already exists");
        //    }

        //    villaDto.Name = villaToPatch.Name;
        //    villaDto.Occupancy = villaToPatch.Occupancy;
        //    villaDto.Sqft = villaToPatch.Sqft;

        //    return Ok(villaDto);
        //}






    }
}
