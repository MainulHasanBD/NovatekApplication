using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Novatek.Models.Entities
{
    [Table("Designation")]
    public class Designation
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? DesignationTitle { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
        public virtual ICollection<Increment>? Increments { get; set; }

    }
}
