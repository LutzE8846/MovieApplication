using Microsoft.EntityFrameworkCore;
using MovieApplication.Entities;
using Newtonsoft.Json;

namespace MovieApplication.Data
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; } = null!;
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)         
        {
        
        }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Movie>().HasData(SeedMovieData());

        }
        public List<Movie> SeedMovieData()
        {
            var moviesToSeed = new List<Movie>();
            using (StreamReader r = new StreamReader(@"MoviesToSeed.json"))
            {
                string json = r.ReadToEnd();
                moviesToSeed = JsonConvert.DeserializeObject<List<Movie>>(json);
            }
            //Ok if this is null.  
            return moviesToSeed;
        }
       

    }
}
