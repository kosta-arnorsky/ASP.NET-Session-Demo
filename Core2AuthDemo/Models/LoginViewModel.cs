using System.ComponentModel.DataAnnotations;

namespace Core2AuthDemo.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username: ")]
        public string Username { get; set; }
    }
}
