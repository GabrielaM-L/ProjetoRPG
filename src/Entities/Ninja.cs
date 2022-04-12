namespace ProjetoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, string Weapon, int Speed)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
            this.Speed = Speed;
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 9)
            {
                return Name + " atacou com " + Weapon + " com bônus de " + Bonus + " e força elevada.";
            }
            else
            {
                return Name + " atacou com " + Weapon + " com bônus de " + Bonus + " e força fraca.";
            }
        }
        public override string Run()
        {
            if (Speed > 7)
            {
                return Name + " correu com velocidade alta";
            }
            else
            {
                return Name + " correu com velocidade baixa";
            }
        }

    }
}