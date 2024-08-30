namespace VillaMon_API.Models
{
    public class VillaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize with a default value

        public DateTime CreatedDate { get; set; }
    }
    
}
