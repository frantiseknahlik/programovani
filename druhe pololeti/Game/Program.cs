Character player = new Mage("Thorin", 100, 2, 100);
List<Enemy> enemies = new List<Enemy>
{
    new Goblin(50),
    new Dragon(120)
};

foreach (var enemy in enemies)
{
    Console.WriteLine($"\n--- Souboj s {enemy.Name} ---");

    while (player.IsAlive() && enemy.IsAlive())
    {
        player.Attack(enemy);

        if (enemy.IsAlive())
        {
            bool blocked = false;
            if (player is IBlockable b)
            {
                blocked = b.Block();
            }

            if (!blocked)
            {
                enemy.Attack(player);
            }
        }

        if (!player.IsAlive())
        {
            Console.WriteLine("\nThorin padl v boji... HRA KONČÍ.");
            return;
        }
    }

    Console.WriteLine($"\n{enemy.Name} byl poražen!");
    player.LevelUp();

    if (player is IHealable healer)
    {
        healer.Heal(30);
    }
}

Console.WriteLine("\nKONEC");