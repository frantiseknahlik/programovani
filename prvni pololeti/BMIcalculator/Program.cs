// Váha kg (int)
// Výška cm (int)
// Váha (kg) / výška (m) * výška (m)

Console.Clear();
// Váha
Console.Write("Zadejte váhu v kg");
float vaha = float .Parse(Console.ReadLine());

//výška
Console.Write("Zadejte výšku v cm");
float vyska = float.Parse(Console.ReadLine());

//výpočet váhy
float vyska2 = vyska / 100.0f
    
//výpočet BMI
float bmi = vaha / (vyska2 + vyska2);

//výpis BMI
Console.WriteLine($"BMI: {bmi:F2}");
