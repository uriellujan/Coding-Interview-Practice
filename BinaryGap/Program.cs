/*
 * Problem: Binary Gap (Codility Lesson 1)
 * ------------------------------------------------------------------
 * Description:
 * Find the longest sequence of zeros that is surrounded by ones at both ends
 * in the binary representation of an integer N.
 * * Example:
 * - 9 (1001) -> Gap is 2.
 * - 20 (10100) -> Gap is 1 (gap of 2 is not closed by a 1).
 * * Strategy:
 * - Convert N to binary string.
 * - Loop through string:
 * - If '0': Increment current counter.
 * - If '1': "Payday" -> Update maxGap if current > max, then reset current.
 * * Complexity:
 * - Time: O(log N) -> The number of bits in N is log2(N).
 * - Space: O(log N) -> To store the binary string.
 */

using System;

namespace CodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            
            // Test Case 1: 9 (1001) -> Gap 2
            Console.WriteLine($"Binary Gap for 9: {sol.BinaryGap(9)}");

            // Test Case 2: 20 (10100) -> Gap 1 (Ignore trailing zeros)
            Console.WriteLine($"Binary Gap for 20: {sol.BinaryGap(20)}");
            
            // Test Case 3: 529 (1000010001) -> Gap 4
            Console.WriteLine($"Binary Gap for 529: {sol.BinaryGap(529)}");
        }
    }

    public class Solution
    {
        public int BinaryGap(int N)
        {
            string binary = Convert.ToString(N, 2);
            int currentGap = 0;
            int maxGap = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    // Just count the zero. Don't update maxGap yet!
                    currentGap++;
                }
                else // It's a '1'
                {
                    // We found a closing wall! Now we check if this gap is the biggest.
                    if (currentGap > maxGap)
                    {
                        maxGap = currentGap;
                    }
                    // Reset the counter for the next potential gap
                    currentGap = 0;
                }
            }
            return maxGap;
        }
    }
}