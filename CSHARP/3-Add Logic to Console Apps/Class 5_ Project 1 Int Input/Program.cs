
///////// PROJECT 1
/* 
using System;


string? userInput;
bool validInput = false;
int inputInt;

do
{
    Console.WriteLine("Enter value between 5 and 10");
    userInput = Console.ReadLine();


    if (int.TryParse(userInput, out inputInt))//(string.IsNullOrEmpty(userInput))
    {
        validInput = inputInt > 4 && inputInt < 11;

        if (validInput)
        {
            Console.WriteLine($"Your input value ({inputInt}) has been accepted.");
            validInput = true;
        }

        else if (inputInt < 5 || inputInt > 10)
        {
            Console.WriteLine($"You entered {inputInt}. Please enter a number between 5 and 10.");
            validInput = false;
        }

        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, p1lease try again");
            validInput = false;
        }

    }

   // else
        //Console.WriteLine("Sorry, you entered an invalid number, please try again");



} while (validInput == false);

////////check method below
do
{
    Console.WriteLine("Enter value between 5 and 10");
    userInput = Console.ReadLine();

   switch (inputInt)
    {
       case < 5:
           System.Console.WriteLine($"You entered {inputInt}. Please enter a number between 5 and 10.");
           validInput = false;
           break;
       case > 10:
           System.Console.WriteLine($"You entered {inputInt}. Please enter a number between 5 and 10.");
           validInput = false;
           break;

    }
}
 */

////////// PROJECT 2

/* bool validInput = false;

do
{
    System.Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    string? userInput = Console.ReadLine();

    string valInput = userInput.Trim().ToLower();

    switch (valInput)
    {
        
        case "administrator":
            System.Console.WriteLine($"Your input value ({userInput}) has been accepted.");
            validInput = true;
            break;
        case "manager":
            System.Console.WriteLine($"Your input value ({userInput}) has been accepted.");
            validInput = true;
            break;
        case "user":
            System.Console.WriteLine($"Your input value ({userInput}) has been accepted.");
            validInput = true;
            break;
        default:
            Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            validInput = false;
            break;
    }

} while (validInput == false); */


//////////// Project 3


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
