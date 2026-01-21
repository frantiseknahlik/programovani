using System;

class Program
{
    static void Main()
    {
        // požádáme uživatele o první číslo
        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine();
        double number1 = Convert.ToDouble(input1);

        // požádáme uživatele o operaci
        Console.WriteLine("Enter operation (+, -, *, /):");
        string operation = Console.ReadLine();

        // požádáme uživatele o druhé číslo
        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine();
        double number2 = Convert.ToDouble(input2);

        // proměnná pro výsledek
        double result = 0;

        // jednoduché podmínky if místo switche
        if (operation == "+")
        {
            result = number1 + number2;
        }
        else if (operation == "-")
        {
            result = number1 - number2;
        }
        else if (operation == "*")
        {
            result = number1 * number2;
        }
        else if (operation == "/")
        {
            if (number2 != 0)
            {
                result = number1 / number2;
            }
            else
            {
                Console.WriteLine("You cannot divide by zero!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Unknown operation!");
            return;
        }

        // vytiskneme výsledek
        Console.WriteLine("Result: " + result);
    }
}