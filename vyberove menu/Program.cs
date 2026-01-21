using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vyber si z menu:");
        Console.WriteLine("1. Vklad na účet");
        Console.WriteLine("2. Výběr z účtu");
        Console.WriteLine("3. Zobrazení zůstatku");

        Console.Write("Zadej číslo: ");
        int volba = int.Parse(Console.ReadLine());

        switch (volba)
        {
            case 1:
                Console.WriteLine("Budete vkládat na účet");
                break;
            case 2:
                Console.WriteLine("Budete vybírat z účtu");
                break;
            case 3:
                Console.WriteLine("Zobrazuji zůstatek na účtu");
                break;
            default:
                Console.WriteLine("Neplatná volba!");
                break;
        }
    }
}