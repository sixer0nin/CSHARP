
/* 
void SayHello()
{
Console.WriteLine("Hello, Console!");
}

SayHello(); */

/* System.Console.WriteLine("Generating random number:");
DisplayRandomNumber();

void DisplayRandomNumber()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        System.Console.Write($"{random.Next(1, 100)} ");
    }

    System.Console.WriteLine();
}
 */
using System;

int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

// Format and display medicine times 
DisplayMedicineTimes();

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimeDifference();
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimeDifference();
}

Console.WriteLine("New Medicine Schedule:");

// Format and display medicine times 
DisplayMedicineTimes();

void DisplayMedicineTimes()
{
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }

}

void AdjustTimeDifference()
{
    // Adjust the times by adding the difference, keeping the value within 24 hours 
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}

Console.WriteLine();