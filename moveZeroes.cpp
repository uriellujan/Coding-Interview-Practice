// Give an array numbers, move all of the 0's to the end of it
// while maintaining the relative order of the non-zero elements
// and it must be done IN-PLACE (nom aking a copy of the array)

// Input: [0, 1, 0, 3, 12]
// Output: [1, 3, 12, 0, 0]

#include <iostream>
#include <vector>
#include <algorithm> // for the built in swap function

using namespace std;

void moveZeroes(vector<int>& nums){
    // this is the "Slow Pointer" that lags behind the "fast pointer"
    int insertPos = 0;

    // this loop IS the "Fast Pointer"
    for(int i = 0; i < nums.size(); i++){
        // If the current number is NOT zero, we will keep it!
        if(nums[i] != 0){
            // Swap the non-zero element to the "insertPos"
            swap(nums[insertPos], nums[i]);

            // Advance the slow pointer so the next non-zero in the array/vector
            // goes in the next slot
            insertPos++; // This is kind of like a snapshot of the "past" to avoid running two loops (more time complexity if we do and thats not good)
        }
    }
}

int main(){

    return 0;
}