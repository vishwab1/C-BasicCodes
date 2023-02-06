using System.ComponentModel.DataAnnotations;

namespace SimpleCWeb.Models
{
    public class User
    {
        [Key]
        public int rollno { get; set; }
        public string  name { get; set; }
    }
}
