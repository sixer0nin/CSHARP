/*
Console.Clear();
int[] inventory = [200, 450, 700, 69, 250];

int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin ++;
    Console.WriteLine($"Bin {bin} = Items: {items} (Total: {sum})");
}
Console.WriteLine($"\nTotal inventory: {sum}");
*/



string[] ordersId = ["B123", "C234", "A345", "C150", "1B77", "G3003", "C235", "B179", "D199"];

int bin = 0;

Console.Clear();
foreach (string orders in ordersId)
{
    //bin++;
    //Console.WriteLine($"#{bin}: {orders}");
    if (orders.Contains("B"))
    {
        bin++;
        Console.WriteLine($"{bin}: {orders}");
    }
}
