using AutoMapper;
using CityInfoAPI.Models;

namespace CityInfoAPI.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile() 
        {
            CreateMap<Entities.City, Models.CityWithoutPointsOfInterestDto>();
        }
    }
}
