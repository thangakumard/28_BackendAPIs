using AutoMapper;

namespace CityInfoAPI.Profiles
{
    public class PointOfIntrestProfile: Profile
    {
        public PointOfIntrestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
        }
    }
}
