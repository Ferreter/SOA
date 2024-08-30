using System.ComponentModel.DataAnnotations;

namespace VillaMon_API.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty; // Initialize with a default value

        public int Occupancy { get; set; }
        public int Sqft { get; set; }

    }
}
