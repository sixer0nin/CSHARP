using System;
using System.Reflection.Metadata;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = [ 90, 86, 87, 98, 100, 94, 90 ];
int[] andrewScores = [92, 89, 81, 96, 90, 89 ];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89 ];
int[] loganScores = [90, 95, 87, 88, 96, 96 ];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92 ];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98 ];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90 ];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91 ];

//Student names
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];

//int[] studentScores = new int[10];
Console.Clear();
Console.WriteLine("Student\t\tGrade\n");

/*
//Actual course work below
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;

    int sumAssignmentScores = 0;


    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    string currentStudentLetterGrade;
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
*/


int[][] studentScores = [sophiaScores, andrewScores, emmaScores, loganScores, beckyScores, chrisScores, ericScores, gregorScores];

for (int i = 0; i < studentScores.Length; i++)
{
    int sum = 0;
    int gradedAssignments = 0;
    
    
    foreach (int score in studentScores[i])
    {
        gradedAssignments += 1;
        
        if (gradedAssignments <= examAssignments)
            sum += score;

        else
            sum += score / 10;
    }

    decimal average = (decimal)sum / examAssignments;

    string studentGrade;
    if (average >= 97 && average <= 100)
        studentGrade = "A+";

    else if (average >= 93)
        studentGrade = "A";

    else if (average >= 90)
        studentGrade = "A-";

    else if (average >= 87)
        studentGrade = "B+";

    else if (average >= 83)
        studentGrade = "B";
    
    else
        studentGrade = "B-";

    Console.Write($"{studentNames[i]}:\t\t{average}\t");
    Console.WriteLine(studentGrade);
}
// above is use of jagged array containing data from multiple arrays