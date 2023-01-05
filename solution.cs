Here is a C# console application that solves the problem:

```C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Longest substring without repeating characters: " + LongestSubstring(input));
    }

    static string LongestSubstring(string s)
    {
        int n = s.Length;
        int res = 0;
        int start = 0;
        string longestSub = "";

        Dictionary<char, int> lastIndex = new Dictionary<char, int>();

        for (int j = 0; j < n; j++)
        {
            if (lastIndex.ContainsKey(s[j]))
            {
                start = Math.Max(start, lastIndex[s[j]] + 1);
            }

            if (res < j - start + 1)
            {
                res = j - start + 1;
                longestSub = s.Substring(start, res);
            }

            lastIndex[s[j]] = j;
        }

        return longestSub;
    }
}
```

This console application reads a string from the user, then finds and prints the longest substring without repeating characters. The `LongestSubstring` function uses a sliding window approach, where it keeps track of the last index of each character in the string. If a character is repeated, the start of the window is moved to the next character after the repeated one. The longest substring is updated whenever a longer one is found.