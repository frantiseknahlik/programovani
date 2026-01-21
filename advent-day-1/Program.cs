string filename = "input.txt";
if (!File.Exists(filename))
{
    Console.WriteLine($"File {filename} does not exist.");
    return;
}
// Pokud soubor existuje tak jeho řádky načtu do proměnné `lines`
string[] lines = File.ReadAllLines(filename);

var numsA = new List<int>();
var numsB = new List<int>();

foreach (string line in lines)
{
    // Tento kód rozdělí daný řádek, jako rozdělovač používá mezeru
    // jsou zde nastaveny option, které zabrání tomu, 
    // že by nám v array zbyly nějaké prázdné písmena
    string[] numStrings = line.Split(' ', options: StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

    if (numStrings.Length != 2)
    {
        Console.WriteLine("File format is not valid.");
        return;
    }

    // Do Listu čísel přidám levé (index 0) a pravé (index 1) číslo
    numsA.Add(int.Parse(numStrings[0]));
    numsB.Add(int.Parse(numStrings[1]));

    // INFO: Nyní máte array numStrings se dvěma položkami
    // a můžete s ním dále pracovat
    Console.WriteLine($"A:{numStrings[0]} B:{numStrings[1]}");

}

// Seřazení seznamů
numsA.Sort();
numsB.Sort();

// Proměnná pro výsledek
int soucet = 0;

// Projdu všechny hodnoty
for (int i = 0; i < numsA.Count; i++)
{
    int a = numsA[i];
    int b = numsB[i];

    int rozdil = a - b;
    
    // když je rozdíl záporný, udělám z něj kladný
    if (rozdil < 0)
    {
        rozdil = rozdil * -1;
    }
    
    // přičtu rozdíl k výsledku
    soucet = soucet + rozdil;
}

// Výpis výsledku
Console.WriteLine("Výsledek je: " + soucet);