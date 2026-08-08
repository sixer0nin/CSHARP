
Console.Clear();

bool looper = true;
do
{

    Console.WriteLine("\nEnter usercode or, \"0\" to exit.\n");
    string? userInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(userInput))
    {
        if (userInput.Equals("1", StringComparison.OrdinalIgnoreCase))
        {

            Random subs = new Random();
            int daysTilExpiration = subs.Next(12);
            int discountPercent = 0;

            if (daysTilExpiration <=10) // smaller to bigger to reduce clustering start with smallest number
            {
                if (daysTilExpiration <=5)
                {
                    if (daysTilExpiration ==1)
                    {
                        Console.Clear();
                        discountPercent = 20;
                        Console.WriteLine($"Your scubsription will expires within {daysTilExpiration} day!\nRenew now and save {discountPercent}%!.");
                    }
                    else if (daysTilExpiration == 0)
                    {
                        Console.Clear();
                        Console.WriteLine ("Your subscription has expired.");
                    }
                    else
                    {
                        Console.Clear();
                        discountPercent = 10;
                        Console.WriteLine($"Your subscription will expire in {daysTilExpiration} days.\nRenew now and save {discountPercent}%!");
                    }
                   
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Your subscription will expire soon! Renew now.");
                }
                
            }
            if (daysTilExpiration > 10)
            {
                Console.Clear();
                Console.WriteLine("");
            }
        }
        else if (userInput.Equals("0", StringComparison.OrdinalIgnoreCase))
        {
            Console.Clear();
            Console.WriteLine("Program Exited");
            looper = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid code");
            looper = true;
        }
    }
} while (looper);