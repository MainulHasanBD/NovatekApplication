using System.ComponentModel.DataAnnotations.Schema;

namespace Novatek.Models.Entities
{
    [Table("Salary")]
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal SalaryAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Employee? Employee { get; set; }

    }
}
