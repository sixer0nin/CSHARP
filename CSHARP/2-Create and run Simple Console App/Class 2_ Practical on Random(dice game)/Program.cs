Console.Clear();
System.Console.WriteLine("\n\t\t\t\t\t  Rolly polly \n\t\t\t\tNazhath Digital Arts Production\n\n\u235f If any two dice you roll result in the same value, you get two bonus points for rolling doubles.");
Console.WriteLine("\u235f If all three dice you roll result in the same value, you get six bonus points for rolling triples.");
Console.WriteLine("\u235f If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game.");

bool rolling = true;
do
{
    
    
    Console.WriteLine("\n\nEnter \"start\". Or,\"stop\" to exit.\n");
    string? userInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(userInput))
    {


        if (userInput.Equals("rol", StringComparison.OrdinalIgnoreCase)
            || (userInput.Equals("1", StringComparison.OrdinalIgnoreCase)))
        {
            Console.Clear();
            System.Console.WriteLine("\t\t\t  Rolly polly \n\t\tby Nazhath Digital Arts Production\n");
            Console.WriteLine("You rolled 3 dices.");
            Random dice = new();
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);
            int score = roll1+roll2+roll3;
            
            
            System.Console.WriteLine($"\n\u0f36 {roll1}\n  +\n\u0f36 {roll2}\n  +\n\u0f36 {roll3}\n  = \n\u0f36 {score}\n");
            rolling = true;
            
            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3) && score >= 15)
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    score += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    score += 2;
                }
            }
            if (score >= 15)
            {
                Console.WriteLine($"\nTotal score: {score}.");
                Console.WriteLine($"You won with a score of {score}!");
            }
            else
            {
                Console.WriteLine($"\nTotal score: {score}.");
                Console.WriteLine("Sorry, your score is too low. Better luck next time!");
            }            
            
        }
        else if (userInput.Equals("stop", StringComparison.OrdinalIgnoreCase)
            || (userInput.Equals("0", StringComparison.OrdinalIgnoreCase)))
        {
            rolling = false;
            Console.Clear();
            System.Console.WriteLine("\nExiting Game!\n");
        }
        
        else
        {
            rolling = true;
            Console.Clear();
            System.Console.WriteLine("\nInvalid input.\n");
        }
    }
} while (rolling);