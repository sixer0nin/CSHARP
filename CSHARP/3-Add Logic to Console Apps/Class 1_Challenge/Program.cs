
/*
string[] users = ["Sundeep", "Nazhath", "Humaam", "Bob", "Emma"];

//string permission = "Admin|Manager";
//int level = 55;

string? userInput = Console.ReadLine();
Console.Clear();
if (!string.IsNullOrEmpty(userInput))
{
    for (string users.)
    if (users.Contains("Sundeep") && string.Equals(userInput, "Sundeep", StringComparison.OrdinalIgnoreCase))
    {

        string permission = "Super Admin";
        int level = 55;
        Console.WriteLine($"Access Level: {level}\nWelcome {permission}");
    }

    else if (users.Contains("Nazhath") && string.Equals(userInput, "Nazhath", StringComparison.OrdinalIgnoreCase))
    {
        string permission = "Admin";
        int level = 53;
        Console.WriteLine($"Access Level: {level}\nWelcome {permission}");
    }

    else if (users.Contains("Humaam") && string.Equals(userInput, "Humaam", StringComparison.OrdinalIgnoreCase))
    {
        string permission = "Manager";
        int level = 20;
        Console.WriteLine($"Access Level: {level}\nWelcome {permission}");
    }

    else if (users.Contains("Bob") && string.Equals(userInput, "Bob", StringComparison.OrdinalIgnoreCase))
    {
        string permission = "User";
        int level = 10;
        Console.WriteLine($"Access Level: {level}\nWelcome {permission}");
    }

    else if (users.Contains("Emma") && string.Equals(userInput, "Emma", StringComparison.OrdinalIgnoreCase))
    {
        string permission = "User";
        int level = 5;
        Console.WriteLine($"Access Level: {level}\nWelcome {permission}");
    }

    else if (userInput.Length < 2)
    {
        Console.WriteLine("Username Invalid");
    }

    else if (!users.Contains(userInput) && userInput.Length > 2)
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }

    else
    {
        Console.WriteLine("Username Invalid");
    }


}
*/

var userRoles = new Dictionary<string, (string Permission, int Level)>
{
    { "Sundeep", ("Super Admin", 55) },
    { "Nazhath", ("Admin", 53) },
    { "Humaam", ("Manager", 20) },
    { "Bob", ("User", 10) },
    { "Emma", ("User", 5) }
};
//Console.Clear();
//Console.WriteLine("\nEnter username:\n");
//string? userInput = Console.ReadLine();


Console.Clear();
Console.WriteLine("\nEnter username:\n");

bool alphaLooper = true;
do
{
    string? userInput = Console.ReadLine();

    if (!string.IsNullOrEmpty(userInput) &&
        userRoles.TryGetValue(userInput, out var role))
    {
        alphaLooper = false;
        
        Console.WriteLine($"Access Level:{role.Level}\nWelcome {role.Permission}");
    }
    else
    {
        alphaLooper = true;
        Console.Clear();
        Console.WriteLine("Username Invalid. \nNote: Your username is case sensitive");
    }
} while (alphaLooper);


