
    public class Warrior : Character, IBlockable, IDescribable
    {
        public string WeaponName { get; set; }

        public Warrior(string name, int health, int level, string weaponName) : base(name, health, level)
        {
            WeaponName = weaponName;
        }

        public override void Attack(Entity target)
        {
            int damage = Level * 8;
            Console.WriteLine($"{Name} útočí mečem {WeaponName} a způsobuje {damage} poškození!");
            target.TakeDamage(damage);
        }

        public bool Block()
        {
           
            bool success = Random.Shared.Next(100) < 40;
            if (success)
            {
                Console.WriteLine($"{Name} zablokoval útok!");
            }
            return success;
        }

        public override void LevelUp()
        {
            base.LevelUp(); 
            Console.WriteLine("Válečníkova síla roste!");
        }

        public void Describe() => Console.WriteLine($"[Popis] Válečník {Name}, Level {Level}, Zbraň: {WeaponName}, HP: {Health}/{MaxHealth}");
    }

    public interface IDescribable
    {
    }