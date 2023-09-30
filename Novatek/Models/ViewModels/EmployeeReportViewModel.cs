namespace Novatek.Models.ViewModels
{
    public class EmployeeReportViewModel
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? CompanyName { get; set; }
        public string? DepartmentName { get; set; }
        public string? DesignationTitle { get; set; }
        public decimal SalaryAmount { get; set; }
    }
}
