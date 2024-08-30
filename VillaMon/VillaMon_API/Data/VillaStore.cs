using VillaMon_API.Models.Dto;

namespace VillaMon_API.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {

            new VillaDTO { Id = 1, Name = "Villa 1", Occupancy = 4, Sqft = 2000 },
            new VillaDTO { Id = 2, Name = "Villa 2", Occupancy = 6, Sqft = 3000 },
            new VillaDTO { Id = 3, Name = "Villa 3", Occupancy = 8, Sqft = 4000 },
                };
    }
            
    
}
