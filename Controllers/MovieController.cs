using System;
using System.Linq;
using ActionFilters.ActionFilters;
using ActionFilters.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public MovieController()
        {
           
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Test");
        }        

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public IActionResult Post([FromBody] Movie movie)
        {            
            return Ok(movie);
        }
    }
}
