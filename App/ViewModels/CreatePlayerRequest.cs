using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreatePlayerRequest
    {
        [Required(ErrorMessage = "Ce champ ne peut pas être vide")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name="User Name")]
        public string UserName { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(15)]
        // [RegularExpression(@"(?=.*\d)(?=.*[A-Z])", ErrorMessage = "Doit contenir au moins 1 Majuscule et 1 chiffre")]
        public string Password { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(15)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Le mot de passe et le mot de passe de confirmation doivent correspondre")]
        public string ConfirmPassword { get; set; }
    }
}