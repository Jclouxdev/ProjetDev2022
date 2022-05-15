namespace App.Models
{
    public class Drop
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Probability { get; set; }
        public Drop(Item item, int probability){
            Item = item;
            Probability = probability;
        }
    }
}