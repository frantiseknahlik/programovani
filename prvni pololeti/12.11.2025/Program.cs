/*
string veta = "Dnes je velmi hezky";

//změna písmem
Console.WriteLine(veta.ToUpper());
Console.WriteLine(veta.ToLower());

//odstranění mezer
Console.WriteLine(veta);
Console.WriteLine(veta.Trim());

//hledání
Console.WriteLine(veta.Contains("Hezky")); // true nebo false
Console.WriteLine(veta.Trim()); // pozice prvního výskyytu

//začíná / končí
Console.WriteLine(veta.Trim().StartsWith("Zítra")); //true nebo false
Console.WriteLine(veta.Trim().EndsWith("Hezky"));
*/

/*
// úkol 1.
Console.WriteLine("Zadejte jméno a příjmení");

string jmeno = Console.ReadLine();

jmeno = jmeno.Trim();

Console.WriteLine(jmeno.Length);
Console.WriteLine(jmeno.ToUpper());
Console.WriteLine(jmeno.Contains("Terka"));
Console.WriteLine(jmeno[0]);
Console.WriteLine(jmeno[jmeno.Length - 1]);
*/

/*
//
string datum = "2025-11-11T16:00";
string rok = datum.Substring(startIndex:0, length:2);
string cas = datum.Substring(11);
string den =  datum.Substring(startIndex:5, length:5);

Console.WriteLine($"Rok: {rok}, cas: {cas}, den: {den}");
//
string text = "cena: 100 kc, Doprava: 50kc";
string opraveno = text.Replace("kc", "CZK");
Console.WriteLine(opraveno);
//
string csvRadek = "Pavel;Novak;30;Praha";
string[] casti = csvRadek.Split(';');

Console.WriteLine($"Jméno: {casti[0]}, Prijmeni: {casti[1]}, Vek: {casti[2]}, Město: {casti[3]}");

//
string veta = "dnes je krásný den";
string[] slova = veta.Split(" ");
Console.WriteLine(slova.Length);
*/


/*
//1
Console.WriteLine("Zadejte jméno a příjmení");
string vstup = Console.ReadLine();
vstup = vstup.Trim().ToUpper();

Console.WriteLine(vstup.IndexOf(" "));

string[] casti = vstup.Split(" ");
char jmeno = casti[0].ToUpper()[0];
string prijmeni = casti[1].ToUpper()[0] + casti[1].Substring(1).ToLower();
Console.WriteLine(jmeno + "." + prijmeni);

//2
string data = "JMENO=Karel;VEK=45;MESTO=Praha;";
string[] casti = data.Split('=',';');
Console.WriteLine($" {casti[0]} {casti[1]} {casti[2]}");
*/


// První způsob (pro ukázku)

string[] radky = File.ReadAllLines("data.txt");

foreach (var Franta in radky)
{
    Console.WriteLine(Franta);
}

// druhý způsob
string cesta = "data.txt";

if (File.Exists(cesta));
{
    StreamReader sr = new StreamReader(cesta);
    string line = sr.ReadLine(); //přečtu první řádek

    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    
    sr.Close(); // zavře soubor
    
    StreamWriter sw = new StreamWriter(cesta, true);
    sw.WriteLine("\nHello World!");
    sw.WriteLine("Dobrý den");

    for (int i = 0; i < 10; i++)
    {
        sw.WriteLine($"Index: {1}");
    }
    sw.Close();
}



