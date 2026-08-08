// A multi leg questionnare asks for input of 2 different kinds of questions, one about the person and the 
//other about the activity. The program then uses the output of boolean variable which are assigned to the possible answers
// to determine the output of the program. The program also uses if statements to determine the output of the program.
//it decide if the var myLove is happy or sad or angry based on the output of the boolean variables.


using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;

///////////////////////////VARIABLES///////////////////////////////////

string theActionQuestion;
string theActivityQestion;
string myLove = "Nazhath"; // MYLOVE NAME
string opt1 = "A"; //OPTIION LETTER TILL NECT SLASH
string opt2 = "B";
string opt3 = "C";
string opt4 = "D"; //

string actionOfPerson1;
string actionOfPerson2;
string actionOfPerson3;
string actionOfPerson4;
string nameOfActivity;
string nameOfActivity2;
string nameOfActivity3;
string nameOfActivity4;

///////////////////////////////////////////////////////////////////////
////////////////////////////VAR VALUES/////////////////////////////////
///////////////////////////////////////////////////////////////////////
actionOfPerson1 = "Cleaning Smokies litter box";
actionOfPerson2 = "Anoyying Risham";
actionOfPerson3 = "To see Risham resting"; 
actionOfPerson4 = "To see Risham sleeping";
nameOfActivity = "Playing football";
nameOfActivity2 = "Playing handball";
nameOfActivity3 = "Athlectics";
nameOfActivity4 = "Swimming";
theActionQuestion = $"What would make {myLove} happy?";
theActivityQestion = $"What activity would {myLove} like to do?";

///////////////////////////////////////////////////////////////////////
//////////////////////////START OF PROGRAM/////////////////////////////
///////////////////////////////////////////////////////////////////////


Console.WriteLine("What is your name?");
string? nameOfPerson = Console.ReadLine();
Console.WriteLine("What is your age?");
int ageOfPerson = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"welcome {nameOfPerson}, let's find out what makes {myLove} happy!");

Console.WriteLine(theActionQuestion); 
Console.Write(opt1 + ": " + actionOfPerson1);
Console.Write(opt2 + ": " + actionOfPerson2);
Console.Write(opt3 + ": " + actionOfPerson3);
Console.Write(opt4 + ": " + actionOfPerson4);

string? actionAnswer = Console.ReadLine();
int userInput = Convert.ToInt32(actionAnswer);
bool isMyLoveHappy;


if (actionAnswer == opt1)
{
    isMyLoveHappy = true;
    string myLovesMood = "happy";
}
else if (actionAnswer == opt2)
{
    isMyLoveHappy = false;
    string myLovesMood = "angry";
}
else if (actionAnswer == opt3)
{
    isMyLoveHappy = true;
    string myLovesMood = "happy";
}
else if (actionAnswer == opt4)
{
    isMyLoveHappy = true;
    string myLovesMood = "happy";
}
else
{
    Console.WriteLine("Invalid option selected. Please select a valid option.");
    return; // Exit the program if an invalid option is selected
}


