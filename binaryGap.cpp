// Binary Gap is a simple but clever bit manipulation puzzle.
// This problem tests if you can translate an integer into binary logic
// without overwhelming you. The strategy to solve this problem is using
// a state machine system.

// Time Complexity: O(logN)
// Space Complexity: O(1)

#include <iostream>
#include <algorithm>

using namespace std;

int binaryGap(int N) {
    int maxGap = 0;
    int currentGap = 0;
    bool foundOne = false; // This is a flag to see if we have found a '1'

    // Loop until we run out of bits
    while (N > 0) {

        // Check the last bit (Standard "Is it off?" check)
        if (N % 2 == 1) {
            // If we are already tracking a gap, checking this 1 should close the gap
            if (foundOne) {
                maxGap = max(maxGap, currentGap);
            }

            // Whether it's the first 1 or the closing 1, we reset the counter
            currentGap = 0;
            foundOne = true; // We are now officially "inside" the binary number
        }
        else {
            // It's a zero. Only count it if we are trapped after a opening '1'
            if (foundOne) {
                currentGap++;
            }
        }

        // Shift bits to the right (Divide by 2)
        N = N / 2;
    }

    return maxGap; // final answer
}

int main() {

    return 0;
}