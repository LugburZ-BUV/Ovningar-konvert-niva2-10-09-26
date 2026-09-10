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
           
            // We define the variabels first outside the loops
            int num1 = 0;
            int num2 = 0;
            string math = "";
            int result = 0;

            // We run 3 seperate loops in order to verify each input seperately

            // Loop for the first number (num1)
            while (true)
            {
                try
                {
                    // If int.parse works we break the loop
                    Console.Write("Ange första talet: ");
                    num1 = int.Parse(Console.ReadLine());
                    break;
                }
                    // If the user inputs anything other than an int we catch it here and give them an error message
                catch (FormatException)
                {
                    Console.WriteLine("Fel inmatning, endast heltal för miniräknaren. Försök igen!");
                }
            }
            
            // Loop for the operator (math)
            while (true)
            {
                Console.Write("Ange räknesätt (+, -, *, /): ");
                math = Console.ReadLine();

                // Here we don't need to use try/catch, we just need to check if it's any of our 4 options
                if (math == "+" || math == "-" || math == "*" || math == "/")
                {
                    // If the input is valid we break the loop
                    break;
                }
                else
                {
                    // If it is anything other than +,-,*,/ we give an error messages and return to the input again
                    Console.WriteLine("Endast +, -, *, / är gilltliga räknesätt" +
                        "\nFörsök igen!");
                }   
            }

            // Loop for the 2nd number (num2)
            while (true)
            {
                try
                {
                    // Here we use switch and case in order to give the proper result for the operator
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
                // We catch if the user enters anything other than an int and print an error message
                catch (FormatException)
                {
                    Console.WriteLine("Fel inmatning, endast heltal för miniräknaren. Försök igen!");
                }
                // Here we catch if the user tries to divide by zero
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Fel inmatning, 0 är inte ett giltligt tal vid division. Försök igen!");
                }
            }
            // If num1, the operator, and num3 all pass their loops we print the result here
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
