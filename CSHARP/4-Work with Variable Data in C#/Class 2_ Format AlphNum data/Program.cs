string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

//For currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//For comma numbers add number after "N". sucha as N4 to display 4 digits after decimal
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

//for percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

//example
decimal priice = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (priice - salePrice), price);

yourDiscount += $"A discount of {((priice - salePrice)/priice):P2}!"; //inserted
Console.WriteLine(yourDiscount);

/* Here's a brief list of categories of these built-in methods so you can get an idea of what's possible.

add blank spaces for formatting purposes (PadLeft(), PadRight())
compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
help you determine what's inside, or even retrieve part of the string (Contains(), StartsWith(), EndsWith(), Substring())
change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
turn a string into an array of strings or characters (Split(), ToCharArray()) */

//example Pad Left/Right (12) means total length equal 12
string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '\u4567'));
Console.WriteLine(input.PadRight(12, '-'));
//outputs:
        //----Pad this
        //Pad this----