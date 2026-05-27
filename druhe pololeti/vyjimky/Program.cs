class Program
{
    static void Main()
    {
 
        Console.WriteLine("Zadej první číslo:");
        string vstup1 = Console.ReadLine();

      
        bool prvniJeCislo = int.TryParse(vstup1, out int prvniCislo);

        
        if (prvniJeCislo == false)
        {
            Console.WriteLine("To není číslo! Program končí.");
            return;
        }

     
        Console.WriteLine("Zadej druhé číslo:");
        string vstup2 = Console.ReadLine();

  
        bool druheJeCislo = int.TryParse(vstup2, out int druheCislo);

    
        if (druheJeCislo == false)
        {
            Console.WriteLine("To není číslo! Program končí.");
            return;
        }

        try
        {
          
            int vysledek = prvniCislo / druheCislo;

       
            Console.WriteLine("Výsledek dělení je: " + vysledek);
        }
        catch (DivideByZeroException)
        {
           
            Console.WriteLine("Chyba: Nelze dělit nulou!");
        }
    }
}