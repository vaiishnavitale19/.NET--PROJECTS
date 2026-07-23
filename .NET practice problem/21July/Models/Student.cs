using System.ComponentModel.DataAnnotations;

namespace _21Jul.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student name is mandatory")]
        [StringLength(20, MinimumLength = 3,
            ErrorMessage = "Student name must be at least 3 letters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Student age is mandatory")]
        [Range(18, 25, ErrorMessage = "Age must be between 18 and 25")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Student mail id is mandatory")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Student enrolled course name is mandatory")]
        public string Course { get; set; } = string.Empty;
    }
}