using System.ComponentModel.DataAnnotations;

namespace MicroTest.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string cost { get; set; }
    }
}
