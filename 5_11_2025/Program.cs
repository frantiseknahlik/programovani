
// Deklerace pole
int[] mojeCisla;

// Initializace
mojeCisla = new int[5];

// KOmbinace
int[] znamky = new int[5];

// přístup k prvkům
znamky[0] = 1; //první pozice je hodnota 1
znamky[1] = 3;
znamky[4] = 2; // poseldní pozice v poli známky

int prvniZnamka = znamky[0];
Console.WriteLine(prvniZnamka);

Console.WriteLine(znamky[3]);


string[] dnyVTydnu = new string[7];

dnyVTydnu[0] = "pondělí";

string[] dnyVTydnuJinak = {"Pondělí", "Úterý", "Středa", "Čtvrtek", "Pátek", "Sobota", "Neděle"};

Console.WriteLine(dnyVTydnuJinak[1] + "," +  dnyVTydnuJinak[5]);
int velikost = dnyVTydnuJinak.Length;

Console.WriteLine("velikost pole Dny v Týdnu: " + velikost);

for (int i = 0; i < velikost; i++)
{
    Console.WriteLine(dnyVTydnuJinak[i]);
}




//1
string[] nakupniSeznam = {"Máslo", "Mléko", "Vejce", "Čokoláda"};
Console.WriteLine(nakupniSeznam[1]);
Console.WriteLine(nakupniSeznam[3]);

int velikos = nakupniSeznam.Length;
Console.WriteLine(velikos);

//2
int[] cisla = { 1, 2, 3, 4, 5, 6 };
int soucet = cisla[0] + cisla[1];
Console.WriteLine(soucet);

cisla[2] = 99;
Console.WriteLine(cisla[2]);




// práce v hodině + programovací stafeta
int[] cisla = new int[5];
for (int i = 0; i < cisla.Length; i++)
{
    Boolean platnyVstup = false;
    while (platnyVstup == false)
    {
        Console.WriteLine("Zadej " + (i + 1) + "cislo");
        string vstup = Console.ReadLine();
        int hodnota = int.Parse(vstup);
        
        if (hodnota <= 5 && hodnota >= 0)
            {
            platnyVstup = true;
            cisla[i] = hodnota;
            }
        else
        {
            Console.WriteLine("špatně zadané číslo zkus to znovu");
        }
    }
}

int soucet = 0;
int minimum = cisla[0];
int maximum = cisla[0];
int pocetPetek = 0;
int pocetJednicek = 0;


for (int i = 0; i < cisla.Length; i++)
{
    soucet =  soucet + cisla[i];
    if (cisla[i] < minimum)
        {
        minimum = cisla[i];
        }

    if (cisla[1] > maximum)
        {
        maximum = cisla[1];
        }
    if (cisla[i] == 5)
    {
        pocetPetek++;
    }
}


double prumer = (double)soucet / cisla.Length;
Console.WriteLine("Průměr je:" +  prumer);
Console.WriteLine("Soucet je:"  +  soucet );
Console.WriteLine("Minimum je:" +  minimum);
Console.WriteLine("Maximum je:" +  maximum);

for (int znamka = 1; znamka <= 5; znamka++)
{
    int pocet = 0;
    for (int j = 0; j < cisla.Length; j++)
    {
        pocet++;
    }
    Console.WriteLine("Pocet " + znamka + " je: " + pocet);
}

for (int i = 0; 1 < cisla.Length; i++)
{
    string slovne = "";
    switch (cisla[i])
    {
        case 1: slovne = "Vyborne"; break;
        case 2: slovne = "Chvalitebné"; break;
        case 3: slovne = "Dobre"; break;
        case 4: slovne = "dostatečně"; break;
        case 5: slovne = "Nedostatečně"; break;
        default: slovne = "x"; break;
    }
    Console.WriteLine("Známka na" + i + ". pozici:"  + slovne);
}
*/



int[] znamky = { 1, 2, 3, 4, 5, };

//for 
for (int i = 0; i < znamky.Length; i++)
{
    Console.WriteLine(znamky[i]);
}

Console.WriteLine("------------------");

//ForReach
foreach (var z:int in znamky)
{
Console.WriteLine(z);
}
*/



// 1. úkol
int[] cisla = new int[10];
for (int i = 0; i < cisla.Length; i++)
{
    Console.Write("Zadej: " + (i + 1) + ". číslo ");
    string vstup = Console.ReadLine();
    int hodnota = int.Parse(vstup);
    cisla[i] = hodnota;
    
}

for (int i = 0; 1 < cisla.Length; i++)
{
    Console.Write(cisla[i] + ", " );
}

Console.WriteLine();

int[] cislaPozpatku = new int[10];
for (int i = cisla.Length - 1 ; 1 >= 0; i--)
{
    Console.Write(cislaPozpatku[i] + ", " );
}


