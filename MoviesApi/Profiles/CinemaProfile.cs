using AutoMapper;
using MoviesAPI.Data.Dto;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>()
            .ForMember(cinemaDto => cinemaDto.Address,
            options => options.MapFrom(cinema => cinema.Address))
            .ForMember(cinemaDto => cinemaDto.Sessions,
            options => options.MapFrom(cinema => cinema.Sessions));
        CreateMap<UpdateCinemaDto, Cinema>();
    }
}
