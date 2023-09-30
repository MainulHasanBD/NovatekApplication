using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Novatek.Models.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(75)]
        public string? FullName { get; set; } 
        public DateTime Dob { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        [MaxLength(50)]
        public string? Phone { get; set; }

        [MaxLength(250)]
        public string? EmployeeAddress { get; set; }
        public int? CompanyId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public DateTime? JoiningDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Department? Department { get; set; }
        public virtual Designation? Designation { get; set; }
        public virtual ICollection<Increment>? Increments { get; set; }
        public virtual ICollection<Salary>? Salaries { get; set; }
    }
}
