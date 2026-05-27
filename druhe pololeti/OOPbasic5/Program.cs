/*
class Product
{
    // Auto-properties
    public string Name { get; set; }
    public double Price { get; set; }

    // Statické proměnné
    private static int _totalProductsCount = 0;
    private static double _totalValue = 0;

    // Konstruktor
    public Product(string name, double price)
    {
        Name = name;
        Price = price;

        // Zvýšíme počet produktů
        _totalProductsCount++;

        // Přičteme cenu do celkové hodnoty skladu
        _totalValue += price;
    }

    // Statická metoda pro výpis souhrnu
    public static void PrintWarehouseSummary()
    {
        Console.WriteLine("Celkem produktů: " + _totalProductsCount +
                          ", Celková hodnota skladu: " + _totalValue);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Vytvoření 3 produktů
        Product p1 = new Product("Notebook", 15000);
        Product p2 = new Product("Myš", 500);
        Product p3 = new Product("Klávesnice", 1200);

        // Výpis souhrnu skladu
        Product.PrintWarehouseSummary();

        Console.ReadLine();
    }
}
*/





class Enemy
{
    // Statická proměnná pro generování ID
    private static int _nextId = 1;

    // Statická vlastnost pro obtížnost
    public static double DifficultyMultiplier { get; set; } = 1.0;

    // Vlastnosti objektu
    public int Id { get; set; }
    public string Name { get; set; }
    public double BaseHealth { get; set; }

    // Vypočítaná vlastnost
    public double CurrentHealth
    {
        get
        {
            return BaseHealth * DifficultyMultiplier;
        }
    }

    // Konstruktor
    public Enemy(string name, double baseHealth)
    {
        Name = name;
        BaseHealth = baseHealth;

        Id = _nextId;
        _nextId++;
    }

    // Statická metoda pro změnu obtížnosti
    public static void SetDifficulty(double multiplier)
    {
        DifficultyMultiplier = multiplier;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Enemy> enemies = new List<Enemy>();

        enemies.Add(new Enemy("Goblin", 100));
        enemies.Add(new Enemy("Orc", 200));
        enemies.Add(new Enemy("Troll", 500));

        Console.WriteLine("=== Obtížnost 1.0 ===");
        foreach (Enemy e in enemies)
        {
            Console.WriteLine("ID: " + e.Id + 
                              ", Name: " + e.Name + 
                              ", Health: " + e.CurrentHealth);
        }

        // Změna obtížnosti
        Enemy.SetDifficulty(2.5);

        Console.WriteLine("\n=== Obtížnost 2.5 ===");
        foreach (Enemy e in enemies)
        {
            Console.WriteLine("ID: " + e.Id +
                              ", Name: " + e.Name +
                              ", Health: " + e.CurrentHealth);
        }

        Console.ReadLine();
    }
}
