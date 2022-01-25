namespace RPG_GFT.src.Entities
{
    public class Characters
    {
        public string Name { get; set; }
        public string HetoType { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public Characters(string Name, string HetoType, int Level, int HP, int MP)
        {
            this.Name = Name;
            this.HetoType = HetoType;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
        }

        public override string ToString()
        {
            return $"{Name} - {HetoType} - {Level} - {HP} - {MP}";
        }

        public string Attack(int a)
        {
            return $"{Name} attacks with {a}HP power!";
        }

        public string Defend()
        {
            return $"{Name} defends!";
        }
    }
}