using System.ComponentModel.DataAnnotations;

namespace Mvc5AuthDemo.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username: ")]
        public string Username { get; set; }
    }
}
