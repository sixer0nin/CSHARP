/*
  string firstName = "Bob";
  int widgetsPurchased = 7;
  testing a change to message

  int widgetsSold = 7;
  Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");

  Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

Random randNum = new();
// Array contains 5 items but only prints out fraud to console.
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue =  randNum.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = randNum.Next(1, 1000).ToString("000");
  
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    if (orderID.Contains("B") || orderID.Contains("C"))
    {
        Console.WriteLine(orderID);
    }
}


