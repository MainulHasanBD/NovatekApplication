using System.ComponentModel.DataAnnotations;

namespace Novatek.Models.ViewModels
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime Dob { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? EmployeeAddress { get; set; }
        public int? CompanyId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public DateTime? JoiningDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
