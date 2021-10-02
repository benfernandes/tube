using System.ComponentModel.DataAnnotations;

namespace Tube.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}