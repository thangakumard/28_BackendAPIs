namespace CityInfoAPI.Models
{
    public class CityWithoutPointsOfInterestDto
    {
        public int Id { get; set; }
        public String Name { get; set; } = String.Empty;
        public string? Description { get; set; }

    }
}
