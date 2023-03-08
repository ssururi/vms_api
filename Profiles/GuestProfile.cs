using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using VMSApi.Dtos;
using VMSApi.Models;

namespace VMSApi.Profiles
{
    public class GuestProfile : Profile
    {
        public GuestProfile()
        {
            CreateMap<Guest, GuestReadDto>();
            CreateMap<GuestWriteDto, Guest>();
        }
    }
}