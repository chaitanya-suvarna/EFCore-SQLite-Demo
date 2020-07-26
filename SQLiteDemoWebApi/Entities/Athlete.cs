using System.ComponentModel.DataAnnotations;

namespace SQLiteDemoWebApi.Entities
{
    public class Athlete
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        [MaxLength(100)]
        public string Sport { get; set; }
    }
}
