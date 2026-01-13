#include <iostream>
#include <vector>
#include <set> // sets are really good for the "Have I seen this?" scenarios
                // such as "taking attendance"

using namespace std;

int missingInteger(vector<int> &A) {
    // Step 1: Create a Set to act as our "Attendance Sheet"
    // Using a set automatically handles duplicates for us
    set<int> present;

    // Step 2: Fill the attendance sheet!
    for (int num : A) {
        // We only care about positive integers so let's filter
        if (num > 0) {
            present.insert(num);
        }
    }

    // Step 3: Find the first student (number) missing.
    // Check 1, then 2, then 3 and so on...
    // The answer for this problem CANNOT be larger than A.size() + 1
    for (int i = 1; i <= A.size() + 1; i++) {
        // If 'i' is NOT in the set, we found our missing number;
        // if not then we return A.size() + 1 as our final answer
        if (present.find(i) == present.end()) {
            return i;
        }
    }

    return 1; // This line should technically be unreachable due to the loop limit
              // but it is good practice to leave it here as a fallback.
}