using AutoMapper;
using Tube.Dtos;
using Tube.Models;

namespace Tube.Profiles
{
    public class StationsProfile : Profile
    {
        public StationsProfile()
        {
            CreateMap<Station, StationReadDto>();
        }
    }
}