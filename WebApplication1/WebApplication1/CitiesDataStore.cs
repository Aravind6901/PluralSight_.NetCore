using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore() ;

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    id = 1,
                    Name = "Chennai City",
                    Description = "With Beach"
                },
                new CityDto()
                {
                    id = 2,
                    Name = "Vijayawada",
                    Description = "With Threaters"
                }
            };
        }
    }
}
