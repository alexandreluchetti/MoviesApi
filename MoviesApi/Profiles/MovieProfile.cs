using AutoMapper;
using MoviesAPI.Data.Dto;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<CreateMovieDto, Movie>();
        CreateMap<UpdateMovieDto, Movie>();
        CreateMap<Movie, UpdateMovieDto>();
        CreateMap<Movie, ReadMovieDto>()
            .ForMember(movieDto => movieDto.Sessions,
            options => options.MapFrom(movie => movie.Sessions));
    }
}
