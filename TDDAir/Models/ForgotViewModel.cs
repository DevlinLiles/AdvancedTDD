using System.ComponentModel.DataAnnotations;

namespace TDDAir.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}