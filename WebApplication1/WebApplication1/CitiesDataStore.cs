using CityInfo.Models;
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
                    Description = "With Beach",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto ()
                        {
                            Id = 1,
                            Name = "Park",
                            Description = "Good park with Gym"
                        },
                        new PointsOfInterestDto ()
                        {
                            Id = 2,
                            Name = "Besant Road",
                            Description = "More Shops"
                        }
                    }
                },
                new CityDto()
                {
                    id = 2,
                    Name = "Vijayawada",
                    Description = "With Threaters",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto ()
                        {
                            Id = 1,
                            Name = "Park",
                            Description = "Good park with Gym"
                        },
                        new PointsOfInterestDto ()
                        {
                            Id = 2,
                            Name = "Besant Road",
                            Description = "More Shops"
                        }
                    }
                }
            };
        }
    }
}
