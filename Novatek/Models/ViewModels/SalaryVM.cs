using Novatek.Models.Entities;

namespace Novatek.Models.ViewModels
{
    public class SalaryVM
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal SalaryAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        
    }
}
