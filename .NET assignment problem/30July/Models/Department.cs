using System.ComponentModel.DataAnnotations;

namespace _30July_assignment.Models
{
    public class Department
    {

        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        [StringLength(100, ErrorMessage = "Department name cannot exceed 100 characters")]
        public string DepartmentName { get; set; }

        public string DepartmentCode { get; set; }

        [Required(ErrorMessage = "Department status is required")]
        public string Status { get; set; }
    }
}
