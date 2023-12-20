using System.ComponentModel.DataAnnotations;

namespace MusteriProject.Models
{
    public class Musteri
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
