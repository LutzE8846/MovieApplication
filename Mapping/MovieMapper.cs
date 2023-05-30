using AutoMapper;

namespace MovieApplication.Mapping
{
    public class MovieMapper : Profile
    {
        public MovieMapper() 
        {
            CreateMap<Entities.Movie, Entities.MovieDTO>();
            CreateMap<Entities.MovieDTO, Entities.Movie>();
            CreateMap<Entities.MovieToPatch, Entities.Movie>();
            CreateMap<Entities.Movie, Entities.MovieToPatch>();
        }
    }
}
