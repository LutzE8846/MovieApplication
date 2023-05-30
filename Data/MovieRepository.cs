using MovieApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace MovieApplication.Data
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }
        public async Task<List<Movie>> GetMoviesAsync()
        {
            var movies = await _context.Movies.ToListAsync();
            return movies;
        }
        public async Task<Movie> GetMovieAsync(int movieId)
        {
           return await _context.Movies.Where(x => x.Id == movieId).FirstOrDefaultAsync();
        }
        public async Task<bool> MovieExistsAsync(int movieId)
        {
            return await _context.Movies.AnyAsync(x=>x.Id == movieId);
        }
        public async Task AddMovieAsync(Movie movie)
        {
            if (movie != null)
            {
                await _context.Movies.AddAsync(movie);
            }
        }
        public void DeleteMovie(Movie movie)
        {
            _context.Movies.Remove(movie);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}
