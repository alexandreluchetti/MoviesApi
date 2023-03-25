﻿using AutoMapper;
using MoviesApi.Data.Dto;
using MoviesApi.Models;

namespace MoviesApi.Profiles;

public class SessionProfile : Profile
{
    public SessionProfile()
    {
        CreateMap<CreateSessionDto, Session>();
        CreateMap<Session, ReadSessionDto>();
    }
}
