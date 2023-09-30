using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Novatek.Models.Entities
{
    [Table("Increment")]
    public class Increment
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int DesignationId { get; set; }
        public decimal IncrementPercentage { get; set; }
        public DateTime IncrementDate { get; set; }

        public virtual Designation? Designation { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
