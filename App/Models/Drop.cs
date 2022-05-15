namespace App.Models
{
    public class Drop
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Probability { get; set; }
    }
}