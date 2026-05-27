using Pokedex;

List<Command> commands = CommandRegistry.GetCommands();
while (true)
{
    Console.Write("Pokedex > ");
    var words = CleanInput(Console.ReadLine());
    if (words.Count() == 0)
        continue;

    var command = commands.Find(c => c.Name == words[0]);
    if (command == null)
    {
        Console.WriteLine("Unknown command...");
        continue;
    }
    command.Action();
}

List<string> CleanInput(string? input)
{
    if (input == null)
    {
        return [];
    }
    return input
        .Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
        .ToList();
}