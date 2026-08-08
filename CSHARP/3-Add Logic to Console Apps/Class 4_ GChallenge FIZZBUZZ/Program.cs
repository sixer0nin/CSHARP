
using System.Globalization;

for (int i = 1; i < 51; i++)
{
    string output = "";
    if (i % 3 == 0) output += "Fizz";
    if (i % 5 == 0) output += "Buzz";
    if (i % 7 == 0) output += "Jazz";

    System.Console.WriteLine($"{i} {output}");
}

//for (int x = 0; x == 80; x +1)