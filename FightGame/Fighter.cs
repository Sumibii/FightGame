namespace FighterSystem;
class Fighter
{
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
        target.Health -= Damage;
        Console.WriteLine($"{Name} attacked {target.Name} and dealt {Damage} damage");
    }
    public bool IsAlive()
    {
        return Health > 0;
    }
}