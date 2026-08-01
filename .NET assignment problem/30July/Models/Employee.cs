using System.ComponentModel.DataAnnotations;

namespace _30July_assignment.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Date of Joining is required")]
        public DateTime DateOfJoining { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public int DepartmentId { get; set; }

        public string Designation { get; set; }

        public string EmploymentStatus { get; set; }
    }
}
