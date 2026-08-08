
Console.Clear();

bool looper = true;
do
{

    Console.WriteLine("Enter usercode");
    string? userInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(userInput))
    {
        if (userInput.Equals("1", StringComparison.OrdinalIgnoreCase))
        {

            Random subs = new Random();
            int daysTilExpiration = 0;//subs.Next(12);
            int discountPercent = 0;

            if (daysTilExpiration < 10)
            {

                if (daysTilExpiration < 5)
                {

                    if (daysTilExpiration == 1)
                    {

                        if (daysTilExpiration == 0)
                        {
                        
                            Console.Clear();
                            Console.WriteLine("Your subscription has expired.");
                            looper = true;
                        }

                    }
                    else
                    {
                        Console.Clear();
                        discountPercent += 20;
                        Console.WriteLine($"Your Subscription expires within a day!\nRenew now and save {discountPercent}%");
                        looper = true;
                    }

                }
                else
                {
                    Console.Clear();
                    discountPercent += 10;
                    Console.WriteLine($"Your subscription expires in {daysTilExpiration} days.\nRenew now and save {discountPercent}%");
                    looper = true;
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Your subscription will expire soon in {daysTilExpiration} days. Renew now!");
                looper = true;
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