namespace App.Models
{
    public interface IUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public int AbilityPower { get; set; }
        public int Armor { get; set; }
        public int MagicResistance { get; set; }
        public int CritRate { get; set; }

        public void TakeMagicalDamage(int damage){
        }

        public void TakePhysicalDamage(int damage){
        }

        public void NormalAttack(IUnit ennemy){
        }

        public void MagicAttack(IUnit ennemy){
        }
    }
}