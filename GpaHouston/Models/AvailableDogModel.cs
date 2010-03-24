using System.ComponentModel.DataAnnotations;

namespace GpaHouston.Models
{
    public class AvailableDogModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}