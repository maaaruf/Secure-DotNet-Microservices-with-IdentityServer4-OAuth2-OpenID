using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movies.API.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("ClientIdPolicy")]
    public class MoviesController : ControllerBase
    {
        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Genre = $"Sample Genre 1",
                    Owner = $"Sample owner 1",
                    ReleaseDate = new System.DateTime(2020, 1, 1)
                },

                new Movie
                {
                    Id = 2,
                    Genre = $"Sample Genre 2",
                    Owner = $"Sample owner 2",
                    ReleaseDate = new System.DateTime(2020, 1, 2)
                },

                new Movie
                {
                    Id = 3,
                    Genre = $"Sample Genre 3",
                    Owner = $"Sample owner 3",
                    ReleaseDate = new System.DateTime(2020, 1, 3)
                },

                new Movie
                {
                    Id = 4,
                    Genre = $"Sample Genre 4",
                    Owner = $"Sample owner 4",
                    ReleaseDate = new System.DateTime(2020, 1, 4)
                },

                new Movie
                {
                    Id = 5,
                    Genre = $"Sample Genre 5",
                    Owner = $"Sample owner 5",
                    ReleaseDate = new System.DateTime(2020, 1, 5)
                }
            };
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
