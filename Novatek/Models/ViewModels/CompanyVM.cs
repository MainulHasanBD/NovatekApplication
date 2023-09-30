using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Novatek.Models.Entities;

namespace Novatek.Models.ViewModels
{
    public class CompanyVM
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "Company Name should not be empty")]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; } = null!;

        [Required(ErrorMessage = "Company Address should not be empty")]
        [DisplayName("Company Address")]
        public string CompanyAddress { get; set; } = null!;

        [Required(ErrorMessage = "City should not be empty")]
        [DisplayName("City")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Country should not be empty")]
        [DisplayName("Country")]
        public string? Country { get; set; }

        [Required(ErrorMessage = "Phone Number should not be empty")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{5})$", ErrorMessage = "Entered phone Number format is not valid.")]
        [DisplayName("Phone Number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Founded Date should not be empty")]
        [DisplayName("Founded Date")]
        public DateTime? FoundedDate { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }

    }
}
