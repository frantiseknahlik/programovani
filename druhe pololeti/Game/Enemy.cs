public abstract class Enemy : Entity
{
    public int Damage { get; set; }

    public Enemy(string name, int health, int damage) : base(name, health)
    {
        Damage = damage;
    }

    public override void Attack(Entity target)
    {
        Console.WriteLine($"{Name} útočí a způsobuje {Damage} poškození!");
        target.TakeDamage(Damage);
    }
}

public class Goblin : Enemy
{
    public Goblin(int health) : base("Goblin", health, 10)
    {
    }
}

public class Dragon : Enemy
{
    public Dragon(int health) : base("Drak", health, 25)
    {
    }
}