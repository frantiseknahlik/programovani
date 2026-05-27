/*
Person person1 = new Person("Vítek");
Console.WriteLine(person1.GetInfo());

Person person2 = new Person("František", 16);
Console.WriteLine(person2.GetInfo());

public class Person
{
    public string Name;
    public int Age;

    public Person(string name)
    {
        Name = name;
        Age = 0;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string GetInfo()
    {
        return $"{Name} is {Age} years old";
    }
}
*/


/*
string name = "František";
double price = 29;

Product product = new Product();
product.Name = name;
product.Price = price;

Console.WriteLine($"{product.Name}: ${product.Price}");

public class Product
{
    private string _name;
    private double _price;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public double Price
    {
        get { return _price; }
        set
        {
            if (value > 0)
            {
                _price = value;
            }
        }
    }
}
*/



/*
Person person = new Person("David", 23, "david.marek@academicschool.cz");

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public Person(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
}
*/