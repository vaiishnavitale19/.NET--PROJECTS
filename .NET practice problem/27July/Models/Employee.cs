using System.ComponentModel.DataAnnotations;

namespace _27July.Controllers.Model
{
    public class Employee
    {
        [Required(ErrorMessage = "Emp Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Emp name is required")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Must be at least 3 leater")]
        public string Name { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Emp Dept is required")]
        [StringLength(25, ErrorMessage = "dept cannot be more than 25 letter")]
        public string Dept { get; set; }

        [Required(ErrorMessage = "Emp PhoneNUM is required")]
        public long PhoneNum { get; set; }
    }
}
