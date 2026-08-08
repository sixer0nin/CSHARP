using System.ComponentModel;

string? userInput = Console.ReadLine();//200;
string employeeName = "John Smith";//Console.ReadLine();

int employeeLevel = Convert.ToInt32(userInput);

string title = "";

switch (employeeLevel)
{
    case <= 100:
        title = "Junior Associate";
        break;
    case <= 200:
        title = "Senior Associate";
        break;
    case <= 300:
        title = "Manager";
        break;
    case <= 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

System.Console.WriteLine($"{employeeName}, {title}");
