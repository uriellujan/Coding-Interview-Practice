/*
 * Problem: First Unique Character in a String (Common Interview Question)
 * ------------------------------------------------------------------
 * Description:
 * Given a string s, find the first non-repeating character in it and return its index.
 * If it does not exist, return -1.
 * * Example:
 * - Input: "google"
 * - Output: 4 (The character 'l' is the first one that appears only once).
 * * Strategy: Dictionary (HashMap)
 * 1. Create a Dictionary to store character frequencies (Char -> Count).
 * 2. Loop 1: Iterate through the string and populate the dictionary.
 * - If char exists: Increment count.
 * - If new: Set count to 1.
 * 3. Loop 2: Iterate through the string again.
 * - Check the dictionary for the current character's count.
 * - If count is 1, return the current index immediately.
 * * Complexity Analysis:
 * - Time Complexity: O(N) -> We iterate through the string exactly twice (2N simplifies to O(N)).
 * - Space Complexity: O(1) -> The dictionary size is limited by the alphabet size (e.g., 26 letters), 
 * so it does not grow infinitely with the input size.
 */

using System;
using System.Collections.Generic;

namespace CodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.FirstUniqChar("google"));   // Output: 4 ('l')
            Console.WriteLine(sol.FirstUniqChar("aabbcc"));   // Output: -1
        }
    }

    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            // 1. Create the Dictionary
            // Key (char) = the letter
            // Value (int) = how many times we've seen it
            Dictionary<char, int> counts = new Dictionary<char, int>();

            // 2. FILL the Dictionary (The "Data Collection" Phase)
            foreach (char c in s)
            {
                // specific syntax: .ContainsKey() returns true/false
                if (counts.ContainsKey(c))
                {
                    // We've seen it! Increase the count.
                    counts[c]++;
                }
                else
                {
                    // First time seeing it! Initialize to 1.
                    counts[c] = 1;
                }
            }

            // 3. CHECK the Dictionary (The "Analysis" Phase)
            for (int i = 0; i < s.Length; i++)
            {
                // We look up the count for the letter at this index
                if (counts[s[i]] == 1)
                {
                    return i; // Winner! This is the first one with a count of 1.
                }
            }

            return -1; // No unique characters found
        }
    }
}