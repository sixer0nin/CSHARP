




Console.Clear();
Console.WriteLine("Enter \"A\" for Name Checker, \"B\" for Equality Checker");

string? userInput = Console.ReadLine();
if (string.Equals(userInput, "A", StringComparison.OrdinalIgnoreCase))
{

    string[] names = ["Amber", "Beatrux", "Cat"];

    Console.Clear();
    Console.WriteLine
    ("\nWelcome to the Name Checker!\n Enter A,B or C depending on your name. Press Q to view all names\n");

    bool noEscape = true;
    do
    {
        var userInputKey = Console.ReadKey();
        if (userInputKey.Key == ConsoleKey.A)
        {
            noEscape = true;
            Console.Clear();
            foreach (string name in names)
                if (name.Contains("A"))
                    Console.WriteLine($"\nYour name is \"{name}\"");


        }

        else if (userInputKey.Key == ConsoleKey.B)
        {
            noEscape = true;
            Console.Clear();
            foreach (string name in names)
                if (name.Contains("B"))
                    Console.WriteLine($"\nYour name is \"{name}\"");

        }

        else if (userInputKey.Key == ConsoleKey.C)
        {
            noEscape = true;
            Console.Clear();
            foreach (string name in names)
                if (name.Contains("C"))
                    Console.WriteLine($"\nYour name is \"{name}\"");

        }

        else if (userInputKey.Key == ConsoleKey.Q)
        {
            noEscape = true;
            Console.Clear();
            for (int i = 0; i < names.Length; i++)
            {
                char letter = (char)('A' + i);
                Console.WriteLine($"{letter}: {names[i]}");
            }


        }

        else
        {
            noEscape = false;
            Console.Clear();
            Console.Write("\nInvalid input, Enter a valid input");
        }
    } while (noEscape);
}

else if (string.Equals(userInput, "B", StringComparison.OrdinalIgnoreCase))
{
    Console.Clear();
    Console.WriteLine
    ("\nWelcome to the Equality Checker!"); //Press \"A\" to check if is equal. Press \"B\" to check if is inequal\n");

    //int saleAmount = 1001;
    //int discount = saleAmount > 1000 ? 100 : 50;

    //Console.WriteLine($"Discount: {discount}");

    Console.WriteLine("Enter 'A' to flip coin, 'B' to exit");

    bool betaNoEscape = true;
    do
    {
        var userInputLetter = Console.ReadKey();

        if (userInputLetter.Key == ConsoleKey.A)
        {
            Console.Clear();
            betaNoEscape = true;
            Random coin = new();
            Console.WriteLine("Enter 'A' to flip coin, 'B' to exit");
            Console.WriteLine((coin.Next(0, 2) == 0) ? "\nheads" : "\ntails");
        }

        else if (userInputLetter.Key == ConsoleKey.B)
        {
            Console.Clear();
            betaNoEscape = false;
            Console.WriteLine("\nFlipper exited");
        }

        else
        {
            Console.Clear();
            betaNoEscape = true;
            Console.Write("\nInvalid");
        }

    } while (betaNoEscape);
}

else
{
    Console.WriteLine("Invalid Input!");
}