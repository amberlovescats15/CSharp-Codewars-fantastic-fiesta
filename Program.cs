using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
        //var test = ArrayOfMultiples(7, 3);
        //Console.WriteLine(string.Join(", ", test));

        //var test = DuplicateCount("brandonwayne");
        //Console.WriteLine(test);

        var test = Number(new List<string> { "a", "b", "c" });
        Console.WriteLine(string.Join(",", test));
    }

    public static int[] ArrayOfMultiples(int num, int length)
    {
        var loops = 1;
        var multiples = new List<int>();
        while (multiples.Count < length)
        {
            if (loops == int.MaxValue) break;
            var insert = num * loops;
            multiples.Add(insert);
            loops++;
        }
        return multiples.ToArray();
    }

    public static int DuplicateCount(string str)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        var split = str.ToLower().Trim().ToList();
        split.ForEach(s =>
        {
            if (!dictionary.ContainsKey(s))
            {
                dictionary[s] = 1;
            }
            else
            {
                dictionary[s] = dictionary[s] + 1;
            }
        });

        var multiples = dictionary.Where(x => x.Value > 1);
        return multiples.Count();
    }

    public static List<string> Number(List<string> lines)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < lines.Count; i++)
        {
            result.Add($"{i+1}: {lines[i]}");
        }
        return result;
    }
}