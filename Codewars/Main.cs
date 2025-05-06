using System;

namespace Practice.Codewars;
public class Main
{

    public int[] ArrayOfMultiples(int num, int length)
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

    public int DuplicateCount(string str)
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

    public List<string> Number(List<string> lines)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < lines.Count; i++)
        {
            result.Add($"{i + 1}: {lines[i]}");
        }
        return result;
    }
}