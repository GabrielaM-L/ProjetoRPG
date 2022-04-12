namespace ProjetoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, string Weapon, int Speed)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
            this.Speed = Speed;
        }
        public override string Run()
        {
            if (Speed > 6)
            {
                return Name + " correu com velocidade alta";
            }
            else
            {
                return Name + " correu com velocidade baixa";
            }
        }
        public override string Attack()
        {
            return Name + " atacou com " + Weapon;
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 5)
            {
                return Name + " atacou com " + Weapon + " com bônus de " + Bonus + " e força elevada.";
            }
            else
            {
                return Name + " atacou com " + Weapon + " com bônus de " + Bonus + " e força fraca.";
            }

        }
    }
}