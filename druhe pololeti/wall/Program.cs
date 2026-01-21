Console.Clear();

Wall wall1 = new Wall(2.5f, 4.0f, "beton");
Wall wall2 = new Wall(3.0f, 5.0f, "cihla");

wall1.PrintInfo();
wall2.PrintInfo();

Console.WriteLine("Plocha první zdi je: " + wall1.GetSurface());
Console.WriteLine("Plocha druhé zdi je: " + wall2.GetSurface());

class Wall
{
    public float height;
    public float width;
    public string material;

    public Wall(float height, float width, string material)
    {
        this.height = height;
        this.width = width;
        this.material = material;
    }

    public float GetSurface()
    {
        return height * width;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Zeď | Výška: " + height + " | Šířka: " + width + " | Materiál: " + material + " | Plocha: " + GetSurface());
    }
}