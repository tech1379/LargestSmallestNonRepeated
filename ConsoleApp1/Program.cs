// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using System.Numerics;



using System;

public class Program
{
    public static (int smallest, int biggest) findLargestAndSmallest(int[] numbers)
    {
        Array.Sort(numbers);
        return (numbers[0], numbers[numbers.Length - 1]);
    }

    public static (int smallest, int biggest) findLargestAndSmallestNonRepeated(int[] numbers)
    {
        Dictionary<int, int> freq = new();
        var array = numbers.ToList();
        for (int i = 0; i < array.Count; i++)
        {
            if (!freq.ContainsKey(array[i]))
            {
                freq.Add(array[i], 1);
            }
            else
            {
                freq[array[i]] += 1;
            }
        }
        foreach (var item in freq.Where(kvp => kvp.Value > 1).ToList())
        {
            freq.Remove(item.Key);
        }
        var finalList = freq.Keys.ToList();
        finalList.Sort();

        if (finalList.Count > 1)
        {
            return (finalList[0], finalList[finalList.Count - 1]);
        }
        else if (finalList.Count == 0)
        {
            return (0, 0);
        }
        else
        {
            return (finalList[0], finalList[0]);
        }

    }

    public static void Main()
    {
        int[] Numbers = { 1, 2, 3, 4, 5, 7, 10, 11, 100, 50, 55, 60, 75, 3 };

        Console.WriteLine(findLargestAndSmallest(Numbers)); //1 and 100
        Console.WriteLine(findLargestAndSmallestNonRepeated(Numbers)); //1 and 100		

        int[] Numbers2 = { 1, 1, 1, 2, 5, 7, 10, 11, 100, 50, 100, 60, 75, 2 };

        Console.WriteLine(findLargestAndSmallestNonRepeated(Numbers2)); //5 and 75		

        int[] Numbers3 = { 1, 2, 1, 1, 1, 1, 1 };

        Console.WriteLine(findLargestAndSmallestNonRepeated(Numbers3)); //2 and 2		

        int[] Numbers4 = { 1, 1, 1, 1, 1, 1, 1 };

        Console.WriteLine(findLargestAndSmallestNonRepeated(Numbers4)); //none


        int[] Numbers5 = { 1, 2, 3, 1, 3 };

    Console.WriteLine(findLargestAndSmallestNonRepeated(Numbers5)); //2 and 2
        
    }
}
