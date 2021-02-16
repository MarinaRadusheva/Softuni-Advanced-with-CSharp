using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        Console.Write("Coins: ");
        int[] availableCoins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        Console.Write("Sum: ");
        var targetSum = int.Parse(Console.ReadLine());

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        List<int> sortedCoins = coins.OrderByDescending(x => x).ToList();
        Dictionary<int, int> change = new Dictionary<int, int>();
        int index = 0;
        int currentSum = 0;
        while (currentSum != targetSum && index != sortedCoins.Count)
        {
            int remainingAmount = targetSum - currentSum;
            int currentCoin = sortedCoins[index];
            if (remainingAmount >= currentCoin)
            {
                int addedCoins = remainingAmount / currentCoin;
                change.Add(currentCoin, addedCoins);
                currentSum += addedCoins * currentCoin;
            }
            index++;
        }
        if (currentSum!=targetSum)
        {
            Console.WriteLine("Error");
            Environment.Exit(0);
        }
        return change;
    }
}
