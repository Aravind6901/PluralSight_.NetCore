using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace CityInfo.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.id == cityId);

            if (city == null)
                return NotFound();

            return Ok(city.PointsOfInterest);
        }


        [HttpGet("{cityId}/pointsofinterest/{id}")]
        public IActionResult GetPointsOfInterest(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.id == cityId);

            if (city == null)
                return NotFound();

            var pointsofinterest = CitiesDataStore.Current.Cities.FirstOrDefault(d => d.id == id);

            if (pointsofinterest == null)
                return NotFound();

            return Ok(pointsofinterest);
        }
    }
}
