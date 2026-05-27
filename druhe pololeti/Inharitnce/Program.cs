Console.WriteLine("EatAndSleep Demo");
(new Cat("Lula")).EatAndSleep();

Console.WriteLine("================");


List<animal> animals =
[

    new Dog("Šrek", "French Bulldog"),
    new Cat("Mica")

];

foreach (animal animal in animals)
{
    animal.Eat();
}

class animal
{
    public string Name { get; set; } = "";

    public animal(string name)
    {
        Name = name;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is  eating");
    }
}

class Dog : animal
{

    public string Breed {get; set;} 
    public Dog(string name, string Brreed) : base(name)
    {
        Breed = Breed;
    }

    public override void Eat()
    {
        Console.WriteLine($"Dog named {Name} is  eating");
    }
    
    public void Bark()
    {
        Console.WriteLine("Haf Haf");
    }
}


class Cat : animal
{
    public Cat(string name) : base(name)
    {
    
    }
    public override void Eat()
    {
        base.Eat();
        Console.WriteLine($"Cat named {Name} is  eating");
    }

    public void EatAndSleep()
    {
        base.Eat();
        Console.WriteLine($"Cat named {Name} is sleeping");
    }
}
