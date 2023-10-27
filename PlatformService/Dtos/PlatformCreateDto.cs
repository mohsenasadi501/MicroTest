using System.ComponentModel.DataAnnotations;

namespace MicroTest.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Publisher { get; set; }
        
        [Required]
        public string cost { get; set; }
    }
}
