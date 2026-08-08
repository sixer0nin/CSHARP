
System.Console.WriteLine("Enter 1 or 2");
string? input = Console.ReadLine();

if (input != null)
{

    if (input == "1")
    {

        //seperate array data with "," and reverse
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        // string result = new string(valueArray);
        string result = String.Join(",", valueArray);
        Console.WriteLine(result);

        string[] items = result.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }

        /*

        OUT PUT
        3,2,1,c,b,a
        3
        2
        1
        c
        b
        a 

        */
    }

    if (input == "2")
    {
        ////Reverse array data
        string pangram = "The quick brown fox jumps over the lazy dog";

        // Step 1
        string[] message = pangram.Split(' ');

        //Step 2
        string[] newMessage = new string[message.Length];

        // Step 3
        for (int i = 0; i < message.Length; i++)
        {
            char[] letters = message[i].ToCharArray();
            Array.Reverse(letters);
            newMessage[i] = new string(letters);
        }

        //Step 4
        string result = String.Join(" ", newMessage);
        Console.WriteLine(result);
    }
}

else
{
    System.Console.WriteLine("Invalid input.");
}