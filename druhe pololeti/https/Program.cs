/*příklad - ukázka

using System.Net.Http;
using System.Text.Json;

HttpClient client = new HttpClient();
try
{
    string response = await client.GetStringAsync("https://catfact.ninja/fact");
}
catch (HttpRequestException)
{
    Console.WriteLine("Error");
    return;
}


Response? r = JsonSerializer.Deserialize<Response>(JsonString);
if (r == null)
{
    Console.WriteLine("nepodařilo se deserializovat");
    return;
}

Console.WriteLine(JsonString);

class Rsponse
{
    public string? fact { get; set; } = "";
    public int? length { get; set; }
}

*/

using System.Net.Http;
using System.Text.Json;

Console.Write("Zadejte své jméno: ");
string name = Console.ReadLine() ?? "";

HttpClient client = new HttpClient();
string json;

try
{
    json = await client.GetStringAsync("https://api.agify.io/?name=" + name);
}
catch (HttpRequestException)
{
    Console.WriteLine("Nepodařilo se připojit k internetu :(");
    return;
}

PersonPrediction? prediction = JsonSerializer.Deserialize<PersonPrediction>(json);
if (prediction == null)
{
    Console.WriteLine("Něco se pokazilo při čtení odpovědi");
    return;
}

Console.WriteLine("Podle statistik je lidem se jménem " + prediction.name + " průměrně " + prediction.age + " let.");

class PersonPrediction
{
    public string? name { get; set; }
    public int? age { get; set; }
    public int? count { get; set; }
}