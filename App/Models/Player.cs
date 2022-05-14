namespace App.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
    }
}