using System;

class Program
{
    static void Main()
    {
        
        int pocetgama = 3;
        int pocetsety = 2;
        
        
        // Výchozí skóre
        int bodyA = 0, bodyB = 0;
        int gamyA = 0, gamyB = 0;
        int setyA = 0, setyB = 0;

        bool advantageA = false;
        bool advantageB = false;

        string[] tenisBody = { "0", "15", "30", "40" };

        while (setyA < pocetsety && setyB < pocetsety) 
        {
            Console.Clear();
            
            // Výpis skóre
            string displayBodyA = bodyA < 4 ? tenisBody[bodyA] : "40";
            string displayBodyB = bodyB < 4 ? tenisBody[bodyB] : "40";

            if (advantageA) displayBodyA = "A";
            if (advantageB) displayBodyB = "A";

            Console.WriteLine("=== TENISOVÝ ZÁPAS ===");
            Console.WriteLine($"SETY: {setyA}-{setyB}");
            Console.WriteLine($"GEMY: {gamyA}-{gamyB}");
            Console.WriteLine($"BODY: {displayBodyA}-{displayBodyB}");
            Console.WriteLine("=======================");
            Console.Write("Kdo získal bod? (a/b): ");
            string vstup = Console.ReadLine();

            if (vstup != "a" && vstup != "b")
            {
                Console.WriteLine("Neplatný vstup! Použij 'a' nebo 'b'.");
                Console.ReadKey();
                continue;
            }

            // Přičítání bodu
            if (vstup == "a")
            {
                // Advantage
                if (bodyA >= 3 && bodyB >= 3)
                {
                    if (advantageB) advantageB = false;
                    else if (advantageA)
                    {
                        // vyhrál gem
                        gamyA++;
                        bodyA = 0; bodyB = 0;
                        advantageA = false;
                        advantageB = false;
                    }
                    else advantageA = true;
                }
                else
                {
                    bodyA++;
                    if (bodyA > 3)
                    {
                        gamyA++;
                        bodyA = 0; bodyB = 0;
                    }
                }
            }
            else // hráč B
            {
                if (bodyA >= 3 && bodyB >= 3)
                {
                    if (advantageA) advantageA = false;
                    else if (advantageB)
                    {
                        // vyhrál gem
                        gamyB++;
                        bodyA = 0; bodyB = 0;
                        advantageA = false;
                        advantageB = false;
                    }
                    else advantageB = true;
                }
                else
                {
                    bodyB++;
                    if (bodyB > 3)
                    {
                        gamyB++;
                        bodyA = 0; bodyB = 0;
                    }
                }
            }

            // Kontrola výhry setu
            if (gamyA >= pocetgama)
            {
                setyA++;
                gamyA = 0;
                gamyB = 0;
            }
            if (gamyB >= pocetgama)
            {
                setyB++;
                gamyA = 0;
                gamyB = 0;
            }
        }

        // Konec zápasu
        Console.Clear();
        Console.WriteLine("=== KONEC ZÁPASU ===");
        if (setyA > setyB) Console.WriteLine("Vítěz: Hráč A");
        else Console.WriteLine("Vítěz: Hráč B");
        Console.WriteLine("Děkujeme za hru!");
    }
}
