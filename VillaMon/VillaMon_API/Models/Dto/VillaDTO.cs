using System.ComponentModel.DataAnnotations;

namespace VillaMon_API.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
