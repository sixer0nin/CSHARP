int targets = 60;
int[] coinss = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[] results = TwoCoins(coinss, targets);

if (results.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions {results[0]} and {results[1]}");
}

int[] TwoCoins(int[] coinss, int targets)
{
    for (int currs = 0; currs < coinss.Length; currs++)
    {
        for (int nexts = currs + 1; nexts < coinss.Length; nexts++)
        {
            if (coinss[currs] + coinss[nexts] == targets)
            {
                return new int[]{ currs, nexts };
            }

        }
    }
    return new int[0];
}



/// return 2D Array

int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoinss(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

int[,] TwoCoinss(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {    
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}