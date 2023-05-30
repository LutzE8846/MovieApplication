using Microsoft.AspNetCore.Mvc;
using MovieApplication.Data;
using MovieApplication.Entities;
using Microsoft.AspNetCore.JsonPatch;
using AutoMapper;

namespace MovieApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepo;
        private readonly IMapper _mapper;

        public MovieController(IMovieRepository movieRepo, IMapper mapper)
        {
            _movieRepo = movieRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<MovieDTO>>> GetAllMovies()
        {
            var movies = await _movieRepo.GetMoviesAsync();
            return Ok(_mapper.Map<List<MovieDTO>>(movies));
        }
        [HttpGet("{movieId}")]
        public async Task<ActionResult<List<MovieDTO>>> GetMovie(int movieId)
        {
            var movie = await _movieRepo.GetMovieAsync(movieId);
            if (movie == null)
            {
                return NotFound("Movie not found.");

            }
            return Ok(_mapper.Map<MovieDTO>(movie));
        }
        [HttpPost]
        public async Task<ActionResult<MovieDTO>> CreateMovie([FromBody] MovieDTO movie)
        {
            if(movie == null)
            {
                return BadRequest();
            }
            var movieToAdd = _mapper.Map<Movie>(movie);
            await _movieRepo.AddMovieAsync(movieToAdd);
            await _movieRepo.SaveChangesAsync();
            return Ok(_mapper.Map<MovieDTO>(movie));
        }
        [HttpPut("{movieId}")]
        public async Task<ActionResult> UpdateMovie(int movieId,[FromBody] MovieDTO movie)
        {
           if(!await _movieRepo.MovieExistsAsync(movieId))
           {
                return NotFound();
           }
            var movieToUpdate = await _movieRepo.GetMovieAsync(movieId);
            _mapper.Map(movie, movieToUpdate);
            await _movieRepo.SaveChangesAsync();
            return NoContent();
        }
        
        [HttpDelete("{movieId}")]
        public async Task<ActionResult> DeleteMovie(int movieId)
        {
            if (!await _movieRepo.MovieExistsAsync(movieId))
            {
                return NotFound("Movie not found, nothing to delete");

            }
            var movieToDelete = await _movieRepo.GetMovieAsync(movieId);
            if(movieToDelete == null)
            {
                return NotFound();
            }
            _movieRepo.DeleteMovie(movieToDelete);
            await _movieRepo.SaveChangesAsync();
            return NoContent();
        }
        [HttpPatch("{movieId}")]
        public async Task<ActionResult> PatchMovie(int movieId, 
            [FromBody] JsonPatchDocument<MovieToPatch> patchDocument)
        {
            if (!await _movieRepo.MovieExistsAsync(movieId))
            {
                return NotFound();
            }
            var movieToUpdate = await _movieRepo.GetMovieAsync(movieId);
            var movieToPatch = _mapper.Map<MovieToPatch>(movieToUpdate);
            patchDocument.ApplyTo(movieToPatch, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(movieToPatch))
            {
                return BadRequest(ModelState);
            }
            _mapper.Map(movieToPatch, movieToUpdate);
            await _movieRepo.SaveChangesAsync();
            return NoContent();
        }
    }
}