/*
 * Problem: Cyclic Rotation (Codility Lesson 2)
 * ------------------------------------------------------------------
 * Description:
 * Rotate an array A to the right by K steps.
 * * Example:
 * A = [3, 8, 9, 7, 6], K = 3
 * Result = [9, 7, 6, 3, 8]
 * * Logic:
 * - We can calculate the exact destination index for every element using modulo math:
 * NewIndex = (OldIndex + K) % Length
 * - We must create a new array to store results to avoid overwriting data in the source array
 * (since arrays are reference types).
 * * Complexity:
 * - Time Complexity: O(N) -> We touch every element exactly once.
 * - Space Complexity: O(N) -> We allocate a new array of size N.
 */

using System;

namespace CodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 3;
            
            int[] result = sol.CyclicRotation(A, K);
            
            // Helper to print array
            Console.WriteLine(string.Join(", ", result)); 
        }
    }

    public class Solution
    {
        public int[] CyclicRotation(int[] A, int K)
        {
            // TODO: Handle edge case if A is empty
            if (A.Length == 0)
            {
                return A;
            }
            // TODO: Create new array of same size
            int[] result = new int[A.Length];
            // TODO: Loop through A, calculate new position using (i + K) % Length
            for (int i = 0; i < A.Length; i++)
            {
                int newPosition = (i + K) % A.Length;
                result[newPosition] = A[i];
            }
            return result;
        }
    }
}