string meessage = "Find what is (inside the parentheses)";

int opeeningPosition = meessage.IndexOf('(');
int cloosingPosition = meessage.IndexOf(')');

Console.WriteLine(opeeningPosition);
Console.WriteLine(cloosingPosition);

// ouput; lenght starting from'('and ')'



string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// output: between the tags



string messsage = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openinggPosition = messsage.IndexOf(openSpan);
int closinggPosition = messsage.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int lenggth = closinggPosition - openinggPosition;
Console.WriteLine(messsage.Substring(openinggPosition, lenggth));

// output; same

// find a certain word or object from string

string message1 = "hello there!";

int first_h = message1.IndexOf('h');
int last_h = message1.LastIndexOf('h');

Console.WriteLine($"For the message: '{message1}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

// output; For the message: 'hello there!', the first 'h' is at position 0 and the last 'h' is at position 7.


// array of items to match

string messagee = "Hello, world!";
char[] charsToFind = [ 'a', 'e', 'i' ];

int indeex = messagee.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{messagee[indeex]}' in '{messagee}' at index: {indeex}.");

string message2 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int clooosingPosition = 0;

while (true)
{
    int oopeningPosition = message2.IndexOfAny(openSymbols, cloosingPosition);

    if (oopeningPosition == -1) break;

    string currentSymbol = message2.Substring(oopeningPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    oopeningPosition += 1;
    clooosingPosition = message2.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int lenngth = clooosingPosition - oopeningPosition;
    Console.WriteLine(message2.Substring(openingPosition, lenngth));
}


string input = "This--is--ex-amp-le--da-ta";
input = input.Replace("--", " ");
input = input.Replace("-", "");
System.Console.WriteLine(input);