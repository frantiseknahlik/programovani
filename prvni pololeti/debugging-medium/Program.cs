/*
// úkol 1

int Bigger(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
*/

/*
// úkol 2

bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Zadej číslo: ");
int n = int.Parse(Console.ReadLine());

if (IsEven(n))
{
    Console.WriteLine("Sudé");
}
else
{
    Console.WriteLine("Liché");
}
*/

/*
// úkol 3

void Countdown(int n)
{
    while (n > 0)
    {
        Console.WriteLine(n);
        n--;
    }
}
*/

/*
// úkol 4

int SumFromOne(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}
*/

/*
// úkol 5

{
    static void Main()
    {
        int choice = 0;

        while (choice != 3)
        {
            Console.WriteLine("1 - Pozdrav");
            Console.WriteLine("2 - Součet dvou čísel");
            Console.WriteLine("3 - Konec");
            Console.Write("Vyber možnost: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Greet();
            }
            else if (choice == 2)
            {
                SumTwoNumbers();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Konec programu.");
            }
            else
            {
                Console.WriteLine("Neplatná volba, zkus to znovu.");
            }

            Console.WriteLine(); // prázdný řádek pro přehlednost
        }
    }

    static void Greet()
    {
        Console.WriteLine("Ahoj!");
    }

    static void SumTwoNumbers()
    {
        Console.Write("Zadej první číslo: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Zadej druhé číslo: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Součet je: " + (a + b));
    }
}
*/
