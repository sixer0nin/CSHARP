using System.Data;


Console.Clear();

bool rolling = true;
do
{
    
    System.Console.WriteLine("\nEnter \"roll\" to see them rolling, hopefully they dont be hatin'. \nTo exit the roller \"stop\".\n" +@"(supported: 0,1,2,3,11)");
    string? userInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(userInput))
    {
        if (userInput.Equals("rol", StringComparison.OrdinalIgnoreCase)
            || (userInput.Equals("1", StringComparison.OrdinalIgnoreCase)))
        {
            Console.Clear();
            Random dice = new();
            int roll1 = dice.Next(1, 2);
            int roll2 = dice.Next(2);
            int roll3 = dice.Next(2);
            int roll4 = dice.Next(2);
            int roll5 = dice.Next(2);
            int roll6 = dice.Next(2);
            System.Console.WriteLine($"\n\u0f36 {roll1} {roll2} {roll3} {roll4} {roll5} {roll6}\n\nDice rolled: {roll1 + roll2 + roll3 + roll4 + roll5 + roll6}.");
            rolling = true;
        }
        else if (userInput.Equals("roll", StringComparison.OrdinalIgnoreCase)
            || (userInput.Equals("2", StringComparison.OrdinalIgnoreCase)))
        {
            Console.Clear();
            Random dye = new();
            int seq1 = dye.Next();
            int seq2 = dye.Next(101);
            int seq3 = dye.Next(50, 201);
            Console.WriteLine($"1st sequence: {seq1}\n2nd Sequence: {seq2}\n3rd Sequence: {seq3}");
            rolling = true;
        }
        else if (userInput.Equals("rolll", StringComparison.OrdinalIgnoreCase)
            || (userInput.Equals("3", StringComparison.OrdinalIgnoreCase)))
        {
            Console.Clear();
            Random dice = new();
            for (uint ctr = 1; ctr <=6; ctr++)
            {
                int rolu = dice.Next(0, 2);
                Console.WriteLine($"{rolu}");
                //Console.WriteLine($"{9:NO}"); 
            }
            rolling = true;
        }
        else if (userInput.Equals("bigger", StringComparison.OrdinalIgnoreCase)
            || (userInput.Equals("11", StringComparison.OrdinalIgnoreCase)))
        {
            Console.Clear();
            int o1 = 0;
            int o2 = 3;
            int o3 = 6;
            int o4 = 9;
            int largerVal = Math.Max(o1, Math.Max(o2, Math.Max(o3, o4)));
            int smallerVal = Math.Min(o1, Math.Min(o2, Math.Min(o3, o4)));
            Console.WriteLine($"\nLarger:{largerVal}\n\nSmaller:{smallerVal}");
        }
        else if (userInput.Equals("stop", StringComparison.OrdinalIgnoreCase)
            || (userInput.Equals("0", StringComparison.OrdinalIgnoreCase)))
        {
            rolling = false;
            Console.Clear();
            System.Console.WriteLine("\nExiting the dice roller. Goodbye!\n");
        }
        
        else
        {
            rolling = true;
            Console.Clear();
            System.Console.WriteLine("\nInvalid input.\n");
        }
    }
} while (rolling);