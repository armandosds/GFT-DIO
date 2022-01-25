namespace RPG_GFT.src.Entities
{
    public class Knigths : Characters
    {
        public Knigths(string Name, string HetoType, int Level, int HP, int MP) : base(Name, HetoType, Level, HP, MP)
        {
        }

        public override string ToString()
        {
            return $"{Name} - {HetoType} - {Level} - {HP} - {MP}";
        }

        public string Attack(int a)
        {
            return $"{Name} attacks with {a}HP Magic!";
        }

        public string Defend()
        {
            return $"{Name} defends!";
        }
    }
}