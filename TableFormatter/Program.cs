/*
 * Problem: Table Formatter (Codility / Real-World Assessment)
 * ------------------------------------------------------------------
 * Description:
 * Given an array of integers A and an integer K, print a formatted ASCII table
 * where each row contains at most K numbers.
 * * Requirements:
 * 1. The width of every cell must equal the length of the longest number in A.
 * 2. Numbers must be right-aligned (padded with spaces to the left).
 * 3. Rows must be separated by border lines (e.g., "+---+").
 * 4. The final row may contain fewer than K items if necessary.
 * * Example Input: A = [4, 35, 80, 123], K = 3
 * Example Output:
 * +---+---+---+
 * |  4| 35| 80|
 * +---+---+---+
 * |123|
 * +---+
 * * Tech Stack: C# (.NET 8.0+), LINQ for calculations.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview
{
    class Program
    {
        // Standard "Main" entry point like in C++ or Java
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            
            // Test Case 1: Standard
            int[] data1 = { 4, 35, 80, 123, 12345, 44, 8, 5 };
            Console.WriteLine("Test Case 1 (K=10):");
            sol.PrintTable(data1, 10);

            Console.WriteLine("\nTest Case 2 (K=4):");
            sol.PrintTable(data1, 4);
        }
    }

    public class Solution 
    {
        public void PrintTable(int[] A, int K) {
            if (A.Length == 0) return;

            // Step 1: Calculate Max Width for padding
            int maxWidth = A.Max(n => n.ToString().Length);

            // Helper function (Local Function) to generate the border string
            string CreateBorder(int count) {
                // Creates one segment like "+-----"
                string segment = "+" + new string('-', maxWidth);
                
                // Repeats that segment 'count' times and adds the closing "+"
                return string.Concat(Enumerable.Repeat(segment, count)) + "+";
            }

            // Step 2: Print the very top border (Logic parity with C++)
            // We need to know how many items are in the first row
            int firstRowCount = Math.Min(K, A.Length);
            Console.WriteLine(CreateBorder(firstRowCount));

            // Step 3: Loop through data in chunks
            for (int i = 0; i < A.Length; i += K) {
                // How many items in *this* specific row?
                int currentChunkSize = Math.Min(K, A.Length - i);

                // Print the Data Row
                Console.Write("|");
                for (int j = 0; j < currentChunkSize; j++) {
                    string numStr = A[i + j].ToString();
                    Console.Write(numStr.PadLeft(maxWidth) + "|");
                }
                Console.WriteLine(); // Newline after data

                // Print the closing border for this row
                Console.WriteLine(CreateBorder(currentChunkSize));
            }
        }
    }
}