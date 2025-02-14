﻿namespace CityInfoAPI.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public String Name { get; set; } = String.Empty;
        public string? Description { get; set; }

        public int NumberOfPointOfInterest
        {
            get
            {
                return PointOfInterests.Count;
            }
        }
        public ICollection<PointOfInterestDto> PointOfInterests { get; set; } 
            = new List<PointOfInterestDto>();
    }
}
