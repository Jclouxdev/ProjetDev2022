namespace App.Models
{
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Physical { get; set; }
        public int Magical { get; set; }
        public int Use(){
            return 1;
        }
    }
}