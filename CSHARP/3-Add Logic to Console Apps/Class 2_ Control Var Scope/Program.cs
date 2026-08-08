//Console.Clear();
/*
bool flag = true;

var userInput = Console.ReadKey();
int value = 0;

if (userInput.Key == ConsoleKey.A)
{
    value = 10; flag = true;
}

if (userInput.Key == ConsoleKey.S)
{
    flag = false; value += 11;
}

if (flag == true)
{
    Console.WriteLine($"Inside the code block: {value}");
}

else
{
    Console.WriteLine($"Outside the code block: {value}");
}


int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total +=number;
    if (number == 42)
    {
        found = true;
        if (found)
        {
            Console.WriteLine("Set contains 42");
            Console.WriteLine($"Total: {total}");
        }
    }
    
}
*/

using System.ComponentModel;

int val = 1;


if (val > 0)
{
    int val2 = 8;
    val = val + val2;
}
System.Console.WriteLine($"{val}");