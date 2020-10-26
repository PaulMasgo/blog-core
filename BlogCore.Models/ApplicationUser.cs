using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace BlogCore.Models
{
    public class ApplicationUser  : IdentityUser
    {
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City  { get; set; }

        [Required(ErrorMessage ="El nombre del pais es nesessrio")]
        public string Country { get; set; }

    }
}
