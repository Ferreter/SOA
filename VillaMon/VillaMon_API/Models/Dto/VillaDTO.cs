using System.ComponentModel.DataAnnotations;

namespace VillaMon_API.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty; // Initialize with a default value
        public string Details { get; set; } = string.Empty;
        [Required]
        public double Rate { get; set; }
        public int Sqft { get; set; }
        public int Occupancy { get; set; } 
        public string ImageUrl { get; set; } = string.Empty;
        public string Amenity { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;  // Location of the villa
        public bool IsAvailable { get; set; } 
    }
}
