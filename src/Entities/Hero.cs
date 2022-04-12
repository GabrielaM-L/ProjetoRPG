namespace ProjetoRPG.src.Entities
{
    public abstract class Hero
    {

        //Criando o construtor:
        public Hero(string Name, int Level, string HeroType, string Weapon, int Speed)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
            this.Speed = Speed;
        }

        public Hero()
        {

        }

        //Declarando as variáveis:
        public string Name;
        public int Level;
        public string HeroType;
        public string Weapon;
        public int Speed;

        //Sobrescrevendo o método ToString()
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        //Criando métodos:
        public virtual string Attack()
        {
            return this.Name + " atacou com " + Weapon;
        }

        public virtual string Run()
        {
            return this.Name + " correu com velocidade " + Speed;
        }
    }
}