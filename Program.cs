using static System.Console;
using RPG_GFT.src.Entities;

namespace RPG_GFT;
class Program
{
    static void Main(string[] args)
    {
        Characters arus = new Characters("Arus", "Human", 1, 100, 100);
        Characters oponnet = new Characters("Smeagle", "Android", 2, 200, 200);
        Wizards wizard = new Wizards("Quako", "Mage", 4, 300, 300);
        Knigths knigth = new Knigths("Gandalf", "Mage", 3, 400, 400);

        WriteLine($"{wizard.Name} is a {wizard.HetoType}, level {wizard.Level}, with {wizard.HP} HP and {wizard.MP} MP.");
        WriteLine();
        WriteLine($"{arus.Name} is a {arus.HetoType}, level {arus.Level}, with {arus.HP} HP and {arus.MP} MP.");
        WriteLine();
        WriteLine($"{oponnet.Name} is a {oponnet.HetoType}, level {oponnet.Level}, with {oponnet.HP} HP and {oponnet.MP} MP.");
        WriteLine();
        WriteLine($"{knigth.Name} is a {knigth.HetoType}, level {knigth.Level}, with {knigth.HP} HP and {knigth.MP} MP.");
        WriteLine();

        WriteLine(arus.Attack(100)); //int.Parse(ReadLine())
        WriteLine();

        WriteLine(oponnet.Defend());
        WriteLine();

        WriteLine(arus.Attack(50));
        WriteLine();

        WriteLine(oponnet.Defend());
        WriteLine();

        WriteLine(wizard.Attack(100));
        WriteLine();

        WriteLine(oponnet.Defend());
        WriteLine();

        WriteLine(knigth.Attack(200));
        WriteLine();

        WriteLine($"{oponnet.Name} is DEAD!!");
        WriteLine();
    }
}
