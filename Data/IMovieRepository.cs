using MovieApplication.Entities;

namespace MovieApplication.Data
{
    public interface IMovieRepository
    {
        Task AddMovieAsync(Movie movie);
        void DeleteMovie(Movie movie);
        Task<Movie> GetMovieAsync(int movieId);
        Task<List<Movie>> GetMoviesAsync();
        Task<bool> SaveChangesAsync();
        Task<bool> MovieExistsAsync(int movieId);
    }
}