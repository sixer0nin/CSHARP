
///////BASIC CALC>>>>>PURPOSE::: MENU OPTIONS FOR MULTIPLE OPTION MENU PRAC/////////
/// Next ver notes>> update if gate so that readLine (usrInp) is a char (+-*/) auto calculate without having to select menu////
//clear initial console

Console.Clear();
Console.WriteLine("\n\t\t  \u0700\u0700" + "Basic Calc by:" + "RISHAAM(\U00013142 )" + "\u0700\u0700");
Console.WriteLine("\t\t\t\u058E\u058E\u058E " + @"Main Menu" + " \u058E\u058E\u058E");

string optAdd = "ADDITION" + " +"; string optSub = "SUBTRACTION" + " -"; string optMulti = "MULTIPLICATION" + " *"; string optDivd = "DIVISION" + " /";
int optAddInt = 1; int optSubInt = 2; int optMultiInt = 3; int optDivdInt = 4;
var validAdd = "1"; var validSub = "2"; var validMulti = "3"; var validDivd = "4";
var validAddChar = @"+";

//Menu loop until valid input.
bool menuLooper = true;
do
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////Cal menu >> User opt Input allocation to Integer variable: validInput ////////////////////
    //Console.WriteLine("\n\t\t  \u0700\u0700" + "Basic Calc by:" + "Nazhath(\U00013142 )" + "\u0700\u0700");
    //Console.WriteLine("\t\t\t\u058E\u058E\u058E " + @"Main Menu" + " \u058E\u058E\u058E");

    Console.Write("\n  Which type of calculation would you like to do? \n  " + @"(Enter 1, 2, 3 or 4. Enter any other value to exit.)" + "\t\n");
    Console.WriteLine("\n   1 \u23F5 " + optAdd + "\n   2 \u23F5 " + optSub + "\n   3 \u23F5 " + optMulti + "\n   4 \u23F5 " + optDivd);
    Console.Write("\n   "); string? usrInpStr = Console.ReadLine();
    int usrInpInt;
    bool usrInpValid = false;
    if (!string.IsNullOrEmpty(usrInpStr))
    {
        if (int.TryParse(usrInpStr, out usrInpInt))//inp as int parse
        {
            usrInpValid = usrInpInt == optAddInt || usrInpInt == optSubInt || usrInpInt == optMultiInt || usrInpInt == optDivdInt;
        }
        else if (usrInpStr.Length == 10 && char.IsLetter(usrInpStr[0])) //Inp as string parse
        {
            char usroptLetter = char.ToUpper(usrInpStr[0]);
            if (usroptLetter == optAdd[0])
                usrInpInt = optAddInt;
            else if (usroptLetter == optSub[0])
                usrInpInt = optSubInt;
            else if (usroptLetter == optMulti[0])
                usrInpInt = optMultiInt;
            else if (usroptLetter == optDivd[0])
                usrInpInt = optDivdInt;

            usrInpValid = usroptLetter == optAdd[0] || usroptLetter == optSub[0] || usroptLetter == optMulti[0] || usroptLetter == optDivd[0];
        }
    }



    ////////////////////////////////////cal menu >> user opt Input validation/////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    //ADDITION//////////////////////////////////////////////////////////
    if (usrInpValid && (usrInpStr == validAdd || usrInpStr == validAddChar))
    {
        //Addition header
        Console.Clear();
        //Console.WriteLine("\n\t\t  \u0700\u0700" + "Basic Calc by:" + "Nazhath(\U00013142 )" + "\u0700\u0700");
        Console.WriteLine("\t\t\t\u058E\u058E\u058E " + @"Addition" + " \u058E\u058E\u058E");

        //input phase
        Console.Write("\n  Insert numbers to add.\n");
        Console.Write("   \u2081\u02E2\u1D57 \u23F5  ");
        decimal numAdd1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("   \u2082\u207F\u1D48 \u23F5  ");
        decimal numAdd2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("   \u2083\u02B3\u1D48 \u23F5  ");
        decimal numAdd3 = Convert.ToDecimal(Console.ReadLine());
        Console.Clear();  //u23F5 arrow right

        //string to display all numbers
        string numSet = $"{numAdd1}" + "+" + $"{numAdd2}" + "+" + $"{numAdd3}";

        //only number 1 & 2 in variable > uses contenation (toAdd + numberOn3)to add number 3 in the final step
        var toAdd = numAdd1 + numAdd2 + numAdd3;
        float truncAdd = (float)toAdd;

        Console.Clear();
        //header
        //Console.WriteLine("\n\t\t  \u0700\u0700" + "Basic Calc by:" + "Nazhath(\U00013142 )" + "\u0700\u0700");
        Console.WriteLine("\u058E\u058E\u058E " + @"Addition result;" + " \u058E\u058E\u058E");

        //output phase
        Console.WriteLine(" \n \U000131E2  " + numSet + " = " + truncAdd + "\n");
        menuLooper = true;




    }
    /////////////////////////////////////////////////////////

    //SUBSTRACTION///////////////////////////////////////
    if (usrInpValid && usrInpStr == validSub)
    {
        Console.Clear();
        Console.Write("\t\t\t\u058E\u058E\u058E " + @"Substraction" + " \u058E\u058E\u058E");
        Console.Write("\n  Add numbers to substract from\n");
        Console.Write("   \u2081\u02E2\u1D57 \u23F5  ");
        decimal numSub1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("   \u2082\u207F\u1D48 \u23F5  ");
        decimal numSub2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("   \u2083\u02B3\u1D48 \u23F5  ");
        decimal numSub3 = Convert.ToDecimal(Console.ReadLine());

        string subSet = $"{numSub1}" + "-" + $"{numSub2}" + "-" + $"{numSub3}";
        var toDiff = numSub1 - numSub2 - numSub3;
        float truncDiff = (float)toDiff;

        Console.Clear();
        Console.WriteLine("\u058E\u058E\u058E " + @"Subtraction result;" + " \u058E\u058E\u058E");
        Console.WriteLine(" \n \U000131E2 " + subSet + " = " + truncDiff);
        menuLooper = true;
    }
    //////////////////////////////////////////////////////////

    //MULTIPLICATION////////////////////////////////////
    if (usrInpValid && usrInpStr == validMulti)
    {
        Console.Clear();
        Console.WriteLine("\t\t\t\u058E\u058E\u058E " + @"Multiplication" + " \u058E\u058E\u058E");
        int value = 2;System.Console.WriteLine(@"v=2");
        value = value + 2;System.Console.WriteLine("First increment\""+@"v=v +2"+"\": "+ value);
        value ++;System.Console.WriteLine("Second increment\""+@"v++"+"\": "+ value);
        value += 1;System.Console.WriteLine("Third increment \""+@"v+= 1"+"\": "+ value);
        value = value - 1;System.Console.WriteLine("1st decrement \""+@"v=v-1"+"\": "+ value);
        value -= 1;System.Console.WriteLine("2nd decrement \""+@"v-="+"\": "+ value);
        value --;System.Console.WriteLine("3rd decrement \""+@"v--"+"\": "+ value);

        int fahrenheit = Convert.ToInt32(Console.ReadLine());
        decimal celcius0 = (fahrenheit - 32m) * (5m/9m);
        System.Console.WriteLine($"The temperature is {celcius0} Celcius");
        int resulto = 3 + 1 * 5 / 2;
        System.Console.WriteLine(resulto);
        System.Console.WriteLine(5 / 10);

    }
    //////////////////////////////////////////////////////////

    //DIVISION//////////////////////////////////////////
    if (usrInpValid && usrInpStr == validDivd)
    {
        Console.Clear();
        Console.WriteLine("\t\t\t\u058E\u058E\u058E " + @"Division" + " \u058E\u058E\u058E");
        Console.Write("\n  Add numbers to divide\n");
        Console.Write("   \u2081\u02E2\u1D57 \u23F5  ");
        decimal numDivd1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("   \u2082\u207F\u1D48 \u23F5  ");
        decimal numDivd2 = Convert.ToDecimal(Console.ReadLine());

        string divSet = $"{numDivd1}" + @"/" + $"{numDivd2}";
        var toDivd = numDivd1 / numDivd2;
        float truncateDecimals = (float)toDivd;

        Console.Clear();
        Console.WriteLine("\u058E\u058E\u058E " + @"Division result;" + " \u058E\u058E\u058E");
        Console.WriteLine("\n \U000131E2 " + divSet + " = " + truncateDecimals);

    }
    /////////////////////////////////////////////////////////

    //INPUT INCORRECT//////////////////////////////////
    else if (usrInpValid && (usrInpStr != validAdd || usrInpStr != validSub || usrInpStr != validMulti || usrInpStr != validDivd))
    {
        Console.WriteLine("\n\t\t  \u0700\u0700" + "Basic Calc by:" + "Rishaam(\U00013142 )" + "\u0700\u0700");
        Console.WriteLine("\t\t\t\u058E\u058E\u058E " + @"Main Menu" + " \u058E\u058E\u058E");
        //Console.Write("\n  Which type of calculation would you like to do, \n  Enter 1, 2, 3, 4 or any other value to exit.\t");
        menuLooper = true;
    }

    //INPUT INVALID////////////////////////////////////
    else
    {
        Console.Clear();
        Console.WriteLine(@"Program closed!" + "\tEnter \"dotnet run\" to enter program again.\n");
        menuLooper = false;
    }
} while (menuLooper);