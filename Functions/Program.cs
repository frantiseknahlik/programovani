void Greet(string name) //void znamená nic, jakoby mi to nic nevrací
{
    Console.WriteLine($"Howdy {name}");
}

int AddTwoNummbers(int a, int b)
{
    return a + b;
}

    void MakeDouble(int x)
    {
        x = x + 2;
    }

Greet("František");
int x = AddTwoNummbers(3, 4);
Console.WriteLine(x);

MakeDouble(x);

Console.WriteLine();

