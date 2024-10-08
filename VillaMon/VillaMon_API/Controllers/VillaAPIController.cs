﻿using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
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
                Location = villaDto.Location,
                IsAvailable = villaDto.IsAvailable

    
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
            // Check if the model state is valid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Check if the ID matches the ID in the DTO
            if (id != villaDto.Id)
            {
                return BadRequest("The ID in the URL does not match the ID in the DTO");
            }

            // Find the existing villa
            var existingVilla = _db.Villas.FirstOrDefault(v => v.Id == id);
            if (existingVilla == null)
            {
                return NotFound();
            }

            // Update the existing villa's properties
            existingVilla.Name = villaDto.Name;
            existingVilla.Occupancy = villaDto.Occupancy;
            existingVilla.Sqft = villaDto.Sqft;
            existingVilla.Amenity = villaDto.Amenity;
            existingVilla.Details = villaDto.Details;
            existingVilla.ImageUrl = villaDto.ImageUrl;
            existingVilla.Rate = villaDto.Rate;
            existingVilla.Location = villaDto.Location;
            existingVilla.IsAvailable = villaDto.IsAvailable;

            // Save changes to the database
            _db.Villas.Update(existingVilla);
            _db.SaveChanges();

            return Ok(villaDto);
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
