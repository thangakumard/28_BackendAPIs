using CityInfoAPI.Models;

namespace CityInfoAPI
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        //public static CitiesDataStore Current { get; set; } = new CitiesDataStore();

        public CitiesDataStore() {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name ="New York",
                    Description ="The one with the big park",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name="Point of interest 1",
                            Description ="Description 1"
                        },
                        new PointOfInterestDto()
                        {
                            Id=2,
                            Name="Point of interest 2",
                            Description ="Description 2"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name ="New York 2",
                    Description ="The one with the big park",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name="Point of interest 1",
                            Description ="Description 1"
                        },
                        new PointOfInterestDto()
                        {
                            Id=2,
                            Name="Point of interest 2",
                            Description ="Description 2"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name ="New York 3",
                    Description ="The one with the big park",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name="Point of interest 1",
                            Description ="Description 1"
                        },
                        new PointOfInterestDto()
                        {
                            Id=2,
                            Name="Point of interest 2",
                            Description ="Description 2"
                        }
                    }
                }
            };
        }
    }
}
