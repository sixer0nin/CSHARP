/* string white = "String with white spaces";

string trimWhite = white.Trim();

string modify = white.Replace("String", "Srting");

System.Console.WriteLine($"{trimWhite} {modify}");

bool value;

value = ! (true && false);

System.Console.WriteLine(value);

string[] employees = ["Humaam", "Nazhath", "Pradesh", "Subar Maniyam"];

for (int i = 0; i < employees.Length; i+= 2)
{
    System.Console.WriteLine($"{i+1} {employees[i]}");
} 


int[] number = [1, 2, 3];
int[] numbers = {3, 2, 1};
int[] numberss = new int[] {1, 2, 3}; 



double str = 1.22465;

//decimal deci = str(decimal) str

string inte = str.ToString("0.000");
System.Console.WriteLine(inte);

int strint = (int)str;
int strint2 = Convert.ToInt32(str);
System.Console.WriteLine(strint + strint2);

int i = 0;
do
{
    System.Console.WriteLine(i);
    i++;
} while (i < 5);

int j = 5;

double raise = Math.Pow(j,2);

System.Console.WriteLine(raise);

int age = 24;

string convage = age.ToString();
string convage2 = Convert.ToString(age);
System.Console.WriteLine($"{convage2}  {convage}");

int x = 5;
double y = 2.7;

double xy;

xy = x / y;

System.Console.WriteLine(x / y);
System.Console.WriteLine(xy);

if (x > 0 )
{
    System.Console.WriteLine("Pos");
}
else if (x < 0)
{
    System.Console.WriteLine("Neg");
}
else
{
    System.Console.WriteLine("Zero");
}

bool bull = (5>3) && (4 < 2);
System.Console.WriteLine(bull);

int intvar = 5;

double dublevar = (double)intvar;
System.Console.WriteLine(dublevar); */

using System.Runtime.InteropServices;

int d = 5;
int f = 2;
int res = d / f;
System.Console.WriteLine(res);

string[] names = ["name", "in", "array"];

string combined = string.Concat(names);
System.Console.WriteLine(combined);

Console.WriteLine(GetNumber());

int GetNumber()
{
    int num = 5;
    int bum = 6;

    int add = num + bum;

    return add;

}