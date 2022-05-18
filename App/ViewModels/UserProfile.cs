using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class UserProfile
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime CreationDate {get; set;}
    }
}