namespace FighterSystem;
class Fighter
{
    static Random rng = new Random(); //rng system by chatgpt since im too tired to do it rn
    public string Name;
    public int Health;

    public int Damage;

    public int CritChance;

    public Fighter(string name, int health, int damage, int critchance)
    {
        Name = name;
        Health = health;
        Damage = damage;
        CritChance = critchance;
    }

    public void Attack(Fighter target)
    {
        int roll = rng.Next(1, 101); 
        if (roll <= CritChance)
        {
        Damage *= 2;
        Console.WriteLine("Critical Hit!");
        }

        target.Health -= Damage;
        Console.WriteLine($"{Name} attacked {target.Name} and dealt {Damage} damage");
    }
    public bool IsAlive()
    {
        return Health > 0;
    }
}