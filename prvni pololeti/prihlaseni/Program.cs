Console.Clear();
string Heslo = "1234";
Console.WriteLine("Zadej heslo: ");
string heslo = Console.ReadLine();
if (heslo == "")
{
    Console.WriteLine("Zadejte heslo");
}
else if (heslo == "1234")
{
Console.WriteLine("Heslo je správně");
}
else
{
    Console.WriteLine("Nezadal jste heslo");
}