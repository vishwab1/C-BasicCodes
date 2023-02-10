using System.ComponentModel.DataAnnotations;

namespace MyWebMVCApplication.Models
{
    public class AddUserViewModel
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
