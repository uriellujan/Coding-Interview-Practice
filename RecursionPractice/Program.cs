/*
 * Problem: Reverse String (Recursive)
 * ------------------------------------------------------------------
 * Description:
 * Reverse a given string using recursion (without using built-in Reverse methods).
 * * Logic:
 * 1. Base Case: If string is empty or length 1, return it.
 * 2. Recursive Step: Take the substring starting from index 1, reverse it, 
 * and append the character at index 0 to the end.
 * * Example Input: "ABC"
 * Call Stack:
 * - Reverse("ABC") -> calls Reverse("BC") + "A"
 * - Reverse("BC")  -> calls Reverse("C") + "B"
 * - Reverse("C")   -> Returns "C" (Base Case)
 * Unwind: "C" + "B" + "A" = "CBA"
 * * Complexity Analysis:
 * - Time Complexity: O(N^2) due to string immutability in C# (creating new strings at each step).
 * - Space Complexity: O(N) due to the recursion stack depth.
 */

using System;

namespace CodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string input = "RecursionInC#";
            string result = sol.ReverseStringRecursively(input);
            Console.WriteLine($"Original: {input}");
            Console.WriteLine($"Reversed: {result}");
        }
    }

    public class Solution
    {
        public string ReverseStringRecursively(string str)
        {
            // TODO: Write the Base Case
            // If str is null or length <= 1, return str.
            if (str == null || str.Length <= 1)
            {
                return str;
            }
            // TODO: Write the Recursive Step
            // return ReverseStringRecursively(everything except first char) + first char;
            // HINT: Use str.Substring(1) to get "everything except first char"
            // HINT: Use str[0] to get the "first char"
            return ReverseStringRecursively(str.Substring(1)) + str[0];
        }
    }
}