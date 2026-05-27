List<Animal> animals =
[
    new Dog(),
    new Cat(),
];

foreach (Animal animal in animals)
{
    animal.MakeSound();
}

var cat = new Cat();
cat.MakeSound();

var dog = new Dog();
dog.MakeSound();


abstract class Animal
{
    public abstract void MakeSound();

    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Haf Hafc");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        throw new NotImplementedException();
    }
}