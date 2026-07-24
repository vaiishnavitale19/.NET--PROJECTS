using System.ComponentModel.DataAnnotations;

namespace _24July.Models
{
    public class Student
    {
        [Required(ErrorMessage ="username mush be meaning full")]
        public string Username { get; set; }

        [Required(ErrorMessage ="password must contain 8 letter")]
        public string Password { get; set; }
    }
}
