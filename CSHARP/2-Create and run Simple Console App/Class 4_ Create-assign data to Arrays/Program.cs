/*
string[] fraudID = new string[4];

fraudID[0] = "O101";
fraudID[1] = "O102";
fraudID[2] = "O103";
fraudID[3] = "O000";
*/

string[] fraudID = ["O101", "O102", "O103", "O000"];

string[] head = new string[4];
head[0] = "Current fraudulant order IDs:";
head[1] = "\n\t\t  \u0700\u0700" + "Nazhath Corps Database(\U00013142 )" + "\u0700\u0700";
head[2] = "ID";
head[3] = "Customer:";

Console.Clear();
Console.WriteLine($"{head[1]}\n\n{head[0]}\n\u23f5 {head[2]}:{fraudID[0]}\n\u23f5 {head[2]}:{fraudID[1]}\n\u23f5 {head[2]}:{fraudID[2]}\n\u23f5 {head[2]}:{fraudID[3]}\n");

fraudID[3] = "O104";
fraudID[0] = "O106";

Console.WriteLine($"Updated fraudIDs:\n\u23f5 {head[2]}:{fraudID[0]}\n\u23f5 {head[2]}:{fraudID[1]}\n\u23f5 {head[2]}:{fraudID[2]}\n\u23f5 {head[2]}:{fraudID[3]}\n");
Console.WriteLine($"\nThere are currently {fraudID.Length} fradulent orders to process in the database.");