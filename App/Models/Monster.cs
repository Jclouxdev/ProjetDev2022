namespace App.Models
{
    public class Monster : IUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public int AbilityPower { get; set; }
        public int Armor { get; set; }
        public int MagicResistance { get; set; }
        public int CritRate { get; set; }

        public void TakeMagicalDamage(int damage){
            if(Health-damage < 0 ){
                Health-=damage;
            } else {
                Health = 0;
            }
        }

        public void TakePhysicalDamage(int damage){
            if(Health-damage < 0 ){
                Health-=damage;
            } else {
                Health = 0;
            }
        }

        public void NormalAttack(IUnit ennemy){
            ennemy.TakePhysicalDamage(AttackDamage);
        }

        public void MagicAttack(IUnit ennemy){
            ennemy.TakeMagicalDamage(AbilityPower);
        }
    }
}