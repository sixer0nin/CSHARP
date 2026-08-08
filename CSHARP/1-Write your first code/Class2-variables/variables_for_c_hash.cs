// method to print variables of different types
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;

//Console.WriteLine('b');
//Console.WriteLine(123);
//Console.WriteLine(0.66f);
//Console.WriteLine(3.666);
//Console.WriteLine(6.36969m);
//Console.WriteLine(true);
//Console.WriteLine(false);

// Variable declarations or setting variables of different types
string nameOfStudent;
string nameOfEquation;
string theQuestion;
string equationOption1;
string equationOption2;
string equationOption3;
int option1;
int option2;
int option3; 
int correctAnswer;
decimal answerInDecimal;
bool isThisTrue = true;
bool isThisFalse = false;

//set variables to values
nameOfStudent = "John Doe" + " " + "Sarah" + " " + "Smith"; 
nameOfEquation = "Addition";
theQuestion = "What is 123 + 456?";
option1 = 123 - 50;
option2 = 456;
option3 = 123 + 456;
equationOption1 = "A";
equationOption2 = "B";
equationOption3 = "C";
correctAnswer = 123 + 456;
answerInDecimal = 0.66m + 3.666m; // Both values have 'm' suffix, so this is correct.
isThisTrue = true;
isThisFalse = false;

// print variables to console
Console.WriteLine(nameOfStudent);
Console.WriteLine(nameOfEquation);
Console.WriteLine(theQuestion);
Console.Write(equationOption1 + ": "); Console.WriteLine(option1);
Console.Write(equationOption2 + ": "); Console.WriteLine(option2);
Console.Write(equationOption3 + ": "); Console.WriteLine(option3);
//Console.WriteLine(answerInDecimal);

//set input answer as string



bool loopCondition = true; // Loop will continue until the user selects the correct answer

do
{
Console.WriteLine("Enter your answer (A, B, C, or the corresponding number):");
string? userInput = Console.ReadLine();
int userAnswer = -1;
bool isValid = false;
if (!string.IsNullOrEmpty(userInput))
{
    // Try parsing as numeric answer
    if (int.TryParse(userInput, out userAnswer))
    {
        isValid = userAnswer == option1 || userAnswer == option2 || userAnswer == option3;
    }
    // Try parsing as letter answer (A, B, or C)
    else if (userInput.Length == 1 && char.IsLetter(userInput[0]))
    {
        char answerLetter = char.ToUpper(userInput[0]);
        if (answerLetter == equationOption1[0]) // 'A'
            userAnswer = option1;
        else if (answerLetter == equationOption2[0]) // 'B'         
            userAnswer = option2;
        else if (answerLetter == equationOption3[0]) // 'C'
            userAnswer = option3;
        
        isValid = answerLetter == equationOption1[0] || answerLetter == equationOption2[0] || answerLetter == equationOption3[0];
    }
}
if (isValid && userAnswer == correctAnswer)
{
    Console.WriteLine($"Correct! The answer is {correctAnswer}");
        loopCondition = false; // Exit the loop after a correct answer
}
else if (isValid && userAnswer != correctAnswer)
{
    Console.WriteLine("Incorrect answer. Please try again.");
        loopCondition = true;
}
else
{
    Console.WriteLine("Invalid answer.  Please try again.");
        loopCondition = true;
}
} while (loopCondition);

