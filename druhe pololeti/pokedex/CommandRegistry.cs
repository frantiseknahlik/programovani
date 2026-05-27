namespace Pokedex;

public class CommandRegistry
{
    public static void Exit()
    {
        Console.WriteLine("Exiting...");
        Environment.Exit(0);
    }

    public static void Help()
    {
        foreach (var cmd in GetCommands())
        {
            Console.WriteLine($"{cmd.Name} : {cmd.Description}");
        }
    }

    public static void Clear()
    {
        Console.Clear();
    }

    public static List<Command> GetCommands()
    {
        return
        [
            new Command("exit", "Exits the app", Exit),
            new Command("help", "Displays help", Help),
            new Command("clear", "Clearing display", Clear)
        ];
    }
}
