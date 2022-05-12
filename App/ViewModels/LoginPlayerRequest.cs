using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class LoginPlayerRequest
    {
        [Required]
        [Display(Name="User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}