using System.ComponentModel.DataAnnotations;

namespace imdb.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Role { get; set; }

        public string Email { get; set; }
    }
}
