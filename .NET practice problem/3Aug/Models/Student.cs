using System.ComponentModel.DataAnnotations;

namespace _3Aug.Models
{
    public class Student
    {
        public int Id { get; set; }


        [Required(ErrorMessage ="name is required")]
        [StringLength(30, MinimumLength =3, ErrorMessage ="name most contain 3 latters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18,25,ErrorMessage ="give valid age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Course is required")]
        public string Course { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Enter valid email")]
        public string Email { get; set; }
    }
}
