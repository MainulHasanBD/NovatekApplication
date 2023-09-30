using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Novatek.Models.Entities
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string CompanyName { get; set; } = null!;

        [MaxLength(250)]
        public string CompanyAddress { get; set; } = null!;

        [MaxLength(25)]
        public string? City { get; set; }

        [MaxLength(25)]
        public string? Country { get; set; }

        [MaxLength(15)]
        public string? Phone { get; set; }
        public DateTime? FoundedDate { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }

    }
}
