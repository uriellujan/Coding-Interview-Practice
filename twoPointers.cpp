// This program can be used as a reference for problems that could benefit
// from using two pointers to move inwards to solve it such as the famous
// palindrome problem

// Time Complexity: O(N)
// Space Complexity: O(1)

#include <iostream>
#include <string>

using namespace std;

bool isPalindrone(string s) {
    int left = 0;
    int right = s.length() - 1;

    while (left < right) {
        // If the characters don't match, it's not a palindrome
        if(s[left] != s[right]) {
            return false; // not a Palindrone
        }
        // Move the pointers inward, closer to each other
        left++;
        right--;
    }
    return true; // Assuming the conditions of the loop are true,
                 // the Input IS a Palindrome
}

int main(){

    return 0;
}