namespace App.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public int AbilityPower { get; set; }
        public int Armor { get; set; }
        public int MagicResistance { get; set; }
        public int Crit { get; set; }
        // test
        public void TakeDamage(int damage){
            if(Health-damage < 0 ){
                Health-=damage;
            } else {
                Health = 0;
            }
        }
    }
}