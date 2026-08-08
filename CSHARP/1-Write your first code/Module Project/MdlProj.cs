using System.Numerics;

int currentAssignments = 5;

string so = "Sophia"; string ni = "Nicolas"; string za = "Zahirah"; string je = "Jeong";
int sophia1 = 93; int nicolas1 = 80; int zahirah1 = 84; int jeong1 = 90;
int sophia2 = 87; int nicolas2 = 83; int zahirah2 = 96; int jeong2 = 92;
int sophia3 = 98; int nicolas3 = 82; int zahirah3 = 73; int jeong3 = 98;
int sophia4 = 95; int nicolas4 = 88; int zahirah4 = 85; int jeong4 = 100;
int sophia5 = 100; int nicolas5 = 85; int zahirah5 = 79; int jeong5 = 97;
int soSum = 0; int niSum = 0; int zaSum = 0; int jeSum = 0;


soSum += sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
niSum += nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
zaSum += zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
jeSum += jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal soAvg = (decimal)soSum / currentAssignments;
decimal niAvg = (decimal)niSum / currentAssignments;
decimal zaAvg = (decimal)zaSum / currentAssignments;
decimal jeAvg = (decimal)jeSum / currentAssignments;




//if (soAvg <= 97 && soAvg >= 100);
//if (soAvg >= 93 && soAvg < 96) ;
//else if (soAvg >= 90 && soAvg < 92);
//else if (soAvg >= 87 && soAvg < 89);
//else if (soAvg >= 83 && soAvg < 86) ;

Console.Clear();
Console.WriteLine("      \u058E\u058E\u058E " + @"Grade Calculations" + " \u058E\u058E\u058E");
System.Console.WriteLine($"\n Total number of assignments: {currentAssignments}\n");
System.Console.WriteLine("  Student\tGrade\n");
System.Console.WriteLine($"  {so}:\t{soAvg}\tA"); System.Console.WriteLine($"  {ni}:\t{niAvg}\tB");
System.Console.WriteLine($"  {za}:\t{zaAvg}\tB"); System.Console.WriteLine($"  {je}:\t{jeAvg}\tA\n");


