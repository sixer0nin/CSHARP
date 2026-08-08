using System.Runtime;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}


bool ShouldPlay()
{
    string? usrInput = Console.ReadLine();

    if (usrInput != null)
    {
        if (usrInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        return false;
    }

    return false;
}


void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1,6);
        var roll = random.Next(1,7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

string WinOrLose(int target, int roll)
{
    if(roll > target)
    {
        return "You Won!";
    }
    else
    {
        return "You Lose!";
    }
}