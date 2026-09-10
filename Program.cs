using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Ovningar_konvert_niva2_10_09_26
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Nivå 2

            // Öv 5
            // Bygg en miniräknare som frågar efter två tal och ett räknesätt (+, -, *, /).
            // Använd try-catch för att hantera felaktig inmatning och division med noll, så att programmet aldrig kraschar.
            Console.WriteLine("Öv 5" +
                "\n");
           
            int num1 = 0;
            int num2 = 0;
            string math = "";
            int result = 0;

            while (true)
            {
                try
                {
                    Console.Write("Ange första talet: ");
                    num1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fel inmatning, endast heltal för miniräknaren. Försök igen!");
                }
            }
            
            while (true)
            {
                Console.Write("Ange räknesätt (+, -, *, /): ");
                math = Console.ReadLine();

                if (math == "+" || math == "-" || math == "*" || math == "/")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Endast +, -, *, / är gilltliga räknesätt" +
                        "\nFörsök igen!");
                }   
            }
            while (true)
            {
                try
                {
                    Console.Write("Ange andra talet: ");
                    num2 = int.Parse(Console.ReadLine());
                    switch (math)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fel inmatning, endast heltal för miniräknaren. Försök igen!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Fel inmatning, 0 är inte ett giltligt tal vid division. Försök igen!");
                }
            }
            Console.WriteLine($"\n" +
                $"Beräknar... " +
                $"\n{num1} {math} {num2} = {result}" +
                $"\n");












            // Öv 6
            // Programmet slumpar fram ett tal mellan 1 och 100.
            // Användaren gissar tills rätt tal hittas.
            // Efter varje gissning ger programmet ledtråden "Högre" eller "Lägre".
            // När användaren gissar rätt ska antalet gissningar visas.
            Console.WriteLine("Öv 6" +
             "\n");













            // Öv 7
            // Skapa ett program där du deklarerar tre variabler med var och tre med dynamic.
            // Testa att ändra typen på en dynamic-variabel under körning och skriv en kommentar om vad som händer.
            // Provocera fram ett körningsfel med dynamic och åtgärda det.
            // Förklara skillnaden mellan var och dynamic.
            Console.WriteLine("Öv 7" +
             "\n");











            Console.WriteLine("Hello, World!");
        }
    }
}
