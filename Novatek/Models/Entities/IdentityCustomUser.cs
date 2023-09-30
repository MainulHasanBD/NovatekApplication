using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Novatek.Models.Entities
{
    public class IdentityCustomUser:IdentityUser
    {
        [Required(ErrorMessage = "Name should not be empty")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Special character should not be entered")]
        [MaxLength(255)]
        public string? FullName { get; set; }
    }
}
