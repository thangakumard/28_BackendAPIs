using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CityInfoAPI.Models
{
    public class PointOfInterestCreationDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
