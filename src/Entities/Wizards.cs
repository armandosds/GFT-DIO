namespace RPG_GFT.src.Entities
{
    public class Wizards : Characters
    {
        public Wizards(string Name, string HetoType, int Level, int HP, int MP) : base(Name, HetoType, Level, HP, MP)
        {
        }

        public override string ToString()
        {
            return $"{Name} - {HetoType} - {Level} - {HP} - {MP}";
        }

        public string Attack(int a)
        {
            if (a >= 100)
            {
                return $"{this.Name} attacks with {a}HP Magic and Bonus Power!";
            }
            else
            {
                return $"{this.Name} attacks with {a}HP Magic!";
            }
        }

        public string Defend()
        {
            return $"{Name} defends!";
        }
    }
}