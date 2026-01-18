// This is a work smarter, not harder problem where the testing inputs could make
// the time/space complexities skyrocket. The solution to this puzzle is based on
// using the modulo operator and an array 

#include <iostream>
#include <vector>

using namespace std;

vector<int> cyclicRotation(vector<int> &A, int K) {
    // Trap 1: Handle empty array edgecase immediately for optimization
    if (A.empty()) {
        return A; // Return empty vector, don't crash by operating on an empty array
    }

    int N = A.size();
    // Trap 2: Optimization for a huge K
    K = K % N;

    // If K is 0 after modulo, no change is needed!
    if (K == 0) {
        return A;
    }

    // Create a result vector of size N
    vector<int> result(N);

    for (int i = 0; i < N; i++) {
        // The formula: calculate the new position directly
        int newPosition = (i + K) % N;

        // Place the current element into its new home
        result[newPosition] = A[i];
    }

    return result; // final answer
}