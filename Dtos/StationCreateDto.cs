using System.ComponentModel.DataAnnotations;

namespace Tube.Dtos
{
    public class StationCreateDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}