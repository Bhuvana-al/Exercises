using System.ComponentModel;

namespace exerciseOne;

class Program
{
    static void Main()
    {
        /*
        // Exercise 1 -- 01 Sep 2026  
        Console.WriteLine("Vänligen ange ditt förnamn");
        string firstName = Console.ReadLine();
        Console.WriteLine("Ditt förnamn är: {0}", firstName);

        Console.WriteLine("Vänligen ange ditt efternamn");
        string surName = Console.ReadLine();
        Console.WriteLine("Ditt efternamn är: {0}", surName);

        string fullName = string.Concat(firstName, " ", surName);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(fullName);
        Console.ResetColor();
        */

        
        //Exercise 2 -- 03 Sep 2026 Created Calculator - Added plus and minus
        // Exercise 3 -- 07 Sep 2026  Added multiplication and division
        
        while (true)
        {
        Console.WriteLine("------ Calculator ------");
        Console.WriteLine("To add press 'a'");
        Console.WriteLine("To subtract press 's'");
        Console.WriteLine("To multiply press 'm'");
        Console.WriteLine("To divide press 'd'");
        Console.WriteLine("Press any other key to exit");

            var key = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(key) || 
                (key is not ("a" or "s" or "m" or "d")))
            {
                Environment.Exit(0);
            }
            
            Console.WriteLine("Enter 2 numbers:");
            var numOne = Console.ReadLine();
            var numTwo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(numOne) || string.IsNullOrWhiteSpace(numTwo))
                {
                    Console.WriteLine("You must enter 2 numbers");
                }
            if (decimal.TryParse(numOne, out decimal firstNum)) 
                {
                    if (decimal.TryParse(numTwo, out decimal secondNum))
                    {
                        switch (key)
                        {
                            case "a":
                                AddNumbers(firstNum, secondNum);
                                break;
                            case "s":
                                SubtractNumbers(firstNum, secondNum);
                                break;
                            case "m":
                                MultiplyNumbers(firstNum, secondNum);
                                break;
                            case "d":
                                DivideNumbers(firstNum, secondNum);
                                break;
                            default:
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{numTwo} is not a valid number");
                    }    
                }
                else
                {
                    Console.WriteLine($"{numOne} is not a valid number");
                }
        }
        
        /*
        // Print a text with mulitple colors
        var text = "\e[0;31mHej \e[0;32mpå \e[0;33mdig! \e[0mFantastiskt";
        Console.WriteLine(text);
        */
        
        /* Exercise 4 -- 07 Sep 2026  Print Multiplication table
        try
        {
        Console.WriteLine("Enter a number whose multiplication table is to be displayed: ");
        var inValue = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inValue))
            {
                throw new Exception("No input");
            }
        int numValue = int.Parse(inValue);
        PrintMultiplicationTable(numValue);
        }
        catch(FormatException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
        */
    }

    static void AddNumbers(decimal n1, decimal n2)
    {
        decimal result = n1 + n2;
        Console.WriteLine($"({n1}) + ({n2}) = {result}");
    }
    static void SubtractNumbers(decimal n1, decimal n2)
    {
        decimal result = n1 - n2;
        Console.WriteLine($"({n1}) - ({n2}) = {result}");
    }

    static void MultiplyNumbers(decimal n1, decimal n2)
    {
        decimal result = n1 * n2;
        Console.WriteLine($"({n1}) * ({n2}) = {result}");
    }

    static void DivideNumbers(decimal n1, decimal n2)
    {
        try
        {
            decimal result = n1/n2;
            Console.WriteLine ($"({n1}) / ({n2}) = {result}");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    /*
    static void PrintMultiplicationTable(int inputNum)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Multiple Table of {inputNum}");
        Console.ResetColor();
        for (int i=1; i<=20; i++)
        {
           Console.WriteLine($"{inputNum} * {i} = {inputNum*i}");
        }
    }*/
}
