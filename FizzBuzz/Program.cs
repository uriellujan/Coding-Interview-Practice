/*
 * Problem: FizzBuzz (Classic Interview Question)
 * ------------------------------------------------------------------
 * Description:
 * Write a program that prints the numbers from 1 to n.
 * - For multiples of 3, print "Fizz".
 * - For multiples of 5, print "Buzz".
 * - For multiples of both 3 and 5, print "FizzBuzz".
 * - Otherwise, print the number itself.
 * * Example Input: n = 15
 * Example Output:
 * 1
 * 2
 * Fizz
 * 4
 * Buzz
 * Fizz
 * ...
 * 14 
 * FizzBuzz
 * * Complexity Analysis:
 * - Time Complexity: O(N) -> We iterate through the numbers 1 to N exactly once.
 * - Space Complexity: O(1) -> We only store a single loop counter variable; no extra data structures used.
 */

using System;

namespace CodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            // Test with 15 (should end with FizzBuzz)
            sol.FizzBuzz(15); 
        }
    }

    public class Solution
    {
        public void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}