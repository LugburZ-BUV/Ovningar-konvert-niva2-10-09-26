using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
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
                "\n Miniräknaren!" +
                "\n");
           
            // We define the variabels first outside the loops
            double num1 = 0.0;
            double num2 = 0.0;
            string math = "";
            double result = 0.0;

            // We run 3 seperate loops in order to verify each input seperately

            // Loop for the first number (num1)
            while (true)
            {
                try
                {
                    // If int.parse works we break the loop
                    Console.Write("Ange första talet: ");
                    num1 = double.Parse(Console.ReadLine());
                    break;
                }
                    // If the user inputs anything other than a double we catch it here and give them an error message
                catch (FormatException)
                {
                    Console.WriteLine("Fel inmatning, endast heltal eller decimal tal med , accepteras (t ex 2 eller 5,3)." +
                        "\nFörsök igen!");
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
                    num2 = double.Parse(Console.ReadLine());
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
                // We catch if the user enters anything other than a double and print an error message
                catch (FormatException)
                {
                    Console.WriteLine("Fel inmatning, endast heltal eller decimal tal med , accepteras (t ex 2 eller 5,3)." +
                        "\nFörsök igen!");
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
            Console.Write("Gissa numret mellan 1 och 100: ");

            // We set our secretNumber as a random int between 1 and 100
            // The random number will change everytime the program is run
            int secretNumber = new Random().Next(1,100);
            int antalGissningar = 0;

            // We use a loop to allow multiple guesses
            while (true)
            {
                try
                {
                    // We use try to check if the guess is an int or not
                    Console.Write("Gissa numret: ");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess > secretNumber)
                    {
                        // If the guess is larger than the secretNumber we print this
                        // and add +1 to the number of guesses (antalGissningar)
                        Console.WriteLine("Lägre!");
                        antalGissningar++;
                    }
                    else if (guess < secretNumber)
                    {
                        // If the guess is smaller than the secretNumber we print this
                        // and add +1 to the number of guesses (antalGissningar)
                        Console.WriteLine("Högre!");
                        antalGissningar++;
                    }
                    else
                    {
                        // If the guess is correct we print this, alongside the number of guesses
                        // and then we break the loop
                        Console.WriteLine($"Det hemliga numret var: {secretNumber}!" +
                            $"\nRätt gissat efter " + antalGissningar + " gissningar." +
                            "\n");
                        break;
                    }
                }
                // If the guess i not an int we catch it here and print an error message
                catch (FormatException)
                {
                    Console.WriteLine("Du måste ange ett heltal för att gissa!");
                }
            }

            // Öv 7
            // Skapa ett program där du deklarerar tre variabler med var och tre med dynamic.
            // Testa att ändra typen på en dynamic-variabel under körning och skriv en kommentar om vad som händer.
            // Provocera fram ett körningsfel med dynamic och åtgärda det.
            // Förklara skillnaden mellan var och dynamic.
            Console.WriteLine("Öv 7" +
             "\n");

            // Variable 1,2,3
            var var1 = "StringTypeVar";
            var var2 = 1;
            var var3 = true;

            // Dynamic 1,2,3
            dynamic dyn1 = "MyDynamic1";
            dynamic dyn2 = "10";
            dynamic dyn3 = false;

            // Dyn1 is a string when we print the first message
            Console.WriteLine($"{dyn1} är en {dyn1.GetType()} dynamisk variabel.");
            Console.Write("Tryck på valfri tangent för att ändra variabeln:");
            Console.ReadKey();
            // After readkey we redefine the dyn1 to an int instead
            // and the program now checks the code again when it reads this part
            // so the dynamic variable now reads as an int
            dyn1 = 25;
            Console.WriteLine($"{dyn1} är nu en {dyn1.GetType()} dynamisk variabel istället!" +
                $"\n");

            Console.WriteLine($"Nu provar vi att multiplicera med dyn3, som är en {dyn3.GetType()}");

            // We use a loop to try to multiply our boolean dynamic variable with itself
            // which allows us to try again if we catch the error
            while (true)
            {
                // We use the Total variable to check if we succefully multiplied dyn3
                var Total = 0;
                Console.Write($"Tryck på valfri tangent för att försöka multiplicera dyn3 med sig själv...");
                Console.ReadKey();
                try
                {
                    // VisualStudio does not underline this code since the dynamic
                    // variable isn't read until we run the program
                    // So it doesn't know that dyn3 is a bool
                    Total = dyn3 * dyn3;
                    Console.WriteLine($"{Total}, är {dyn3}^2!");
                }
                // We catch the error here
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR! Försökte multiplicera {dyn3.GetType()}");
                    // And change the type of dyn3 to an int here
                    dyn3 = 9;
                    Console.WriteLine($"Ändrar den dynamiska variabeln till en {dyn3.GetType()}.");
                }
                // When we can succefully multiply dyn3 with itself we break the loop here
                if (Total >0)
                    break;
            }
            // A var is a fixed variable whoose type is defined before the program is run
            // and produces an error in VisualStudio if there's a conflict

            // A dynamic is a variable that isn't defined untill the program runs the code
            // and does not produce an error in VisualStudio if there's a conflict,
            // which means a program can run succesfully until it encounters the problomatic dynamic
        }
    }
}
