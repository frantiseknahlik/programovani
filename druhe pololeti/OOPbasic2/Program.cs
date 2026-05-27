/*
Console.Clear();
Book book = new Book("Karel Hynek Mácha", 1948, 187, "Cikáni");
book.PrintInfo();

class Book
{
    public string Autor;
    public int ReleaseYear;
    public int PageCount;
    public string Name;

    public Book(string Autor, int ReleaseYear, int PageCount, string Name)
    {
        this.Autor = Autor;
        this.ReleaseYear = ReleaseYear;
        this.PageCount = PageCount;
        this.Name = Name;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ReleaseYear: {ReleaseYear}");
        Console.WriteLine($"PageCount: {PageCount}");
        Console.WriteLine($"Name: {Name}");
    }
}
*/

Console.Clear();

List<Student> StudentList = new List<Student>();

while (true)
{
    Console.WriteLine("Zadejte KONEC pro ukonceni");
    Console.Write("Zadejte jméno studenta: ");
    string jmeno = Console.ReadLine();

    if (jmeno == "KONEC")
    {
        break;
    }

    Console.Write("Zadejte věk studenta: ");
    string vek = Console.ReadLine();
    int vek2 = int.Parse(vek);

    // Zde pravděpodobně chybí vytvoření instance Student a přidání do listu:
    // StudentList.Add(new Student(jmeno, vek2));
}

foreach (var student in StudentList)
{
    student.Greet();
}