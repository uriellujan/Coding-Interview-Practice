// The Valid Anagram problem is to figure out if a string is an anagram another string
// An anagram must use the same characters like "listen" and "silent".
// The solution to this problem is similar to the First Unique Character
// Problem I did earlier. Just as in the First Unique Character Problem,
// I used a hashmap to count character frequencies in a given string.
// For this problem I must do the same by adding a tally of 1 for every
// charcter found in the first string and subtracting 1 character for
// ever letter found in the second string that matches a character from
// the first string. The total should be exactly 0 if two strings are
// truly anagrams.

// Time Complexity: O(N)
// Space Complexity: O(1)

#include <iostream>
#include <string>
#include <vector>

using namespace std;

bool isAnagram(string s, string t){
    // Optimization: If the length is different, they are straight up NOT anagrams.
    if(s.length() != t.length()){
        return false;
    }

    // Creating a "bucket" for each letter 'a' through 'z' and initializing
    // all buckets to 0. Here we will keep track of letter frequencies
    int counts[26] = {0};

    // Here I am looping through BOTH strings at the same time for better
    // time efficiency and we are doing another PINCER movement where we
    // meet in the middle of an array in this case.
    for(int i = 0; i < s.length(); i++){
        counts[s[i] - 'a']++; // Increment for string s
        counts[t[i] - 'a']--; // Decrement for string t
    }

    // This for-loop checks if everything is balanced to 0 as
    // an anagram should be. If this doesn't check out it's
    // not an anagram because there is different characters
    for(int i = 0; i < 26; i++){
        if(counts[i] != 0) {
            return false;
        }
    }

    // At this point all rules of an anagram are passed and
    // if the loops above did not detect flaws in the strings
    // the strings ARE VALID ANAGRAMS.
    return true;
}

int main(){
    return 0;
}