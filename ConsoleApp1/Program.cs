// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using System.Numerics;


List<int> numbers = new List<int>() { 2, 22333, 454653, 8888, 999, 99988 };


Console.WriteLine(oddEven(numbers));

static string oddEven(List<int> numbers)
{
    List<string> list = numbers.ConvertAll<string>(x => x.ToString());

    foreach(string c in list)
    {
        int countEven = c.Select(x => x - '0').Count(x => x % 2 == 0);
        int countOdd = c.Select(x => x - '0').Count(x => x % 2 != 0);

        if (countEven % 2 == 0 && countOdd % 2 != 0)
        {
            Console.WriteLine("YES");
        }
        else if(countEven % 2 == 0 && countOdd == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
           Console.WriteLine("NO");
        }
    }

    return "";
}