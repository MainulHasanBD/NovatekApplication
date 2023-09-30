using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Novatek.Models.Entities
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? DepartmentName { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
