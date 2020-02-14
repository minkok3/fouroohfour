using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FourOohFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitiesController : ControllerBase
    {
        private ILogger<CitiesController> _logger;

        private static readonly City[] Cities = new[]
        {
            new City {Id = 1, Name = "London"},
            new City {Id = 2, Name = "Amsterdam"},
            new City {Id = 3, Name = "Paris"}
        };

        public CitiesController(ILogger<CitiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<City> Get()
        {
            return Cities;
        }

        [HttpGet("{id}")]
        public City GetById(int id)
        {
            return Cities.FirstOrDefault(x => x.Id == id);
        }
    }
}
