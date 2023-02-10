using System.ComponentModel.DataAnnotations;

namespace MyWebMVCApplication.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
