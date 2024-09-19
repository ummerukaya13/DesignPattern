using FactoryDesignPatternDemo.Enums;
using FactoryDesignPatternDemo.Factories;
using Microsoft.AspNetCore.Mvc;

namespace FactoryDesignPatternDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StreamController : ControllerBase
    {
        private readonly StreamFactory _streamFactory;

        public StreamController(StreamFactory streamFactory)
        {
            _streamFactory = streamFactory;
        }

        [HttpGet("movies/{userSelection}")]
        public IActionResult GetMovies(StreamType userSelection)
        {
            var movies = _streamFactory.GetStreamService(userSelection).ShowMovies();
            return Ok(movies);
        }
    }
}
