#include <vector>
#include <algorithm> // for std::swap

using namespace std;

void reverseString(vector<char> &s) {
    int left = 0;
    int right = s.size() - 1;

    while (left < right) {
        // The "Action" step
        swap(s[left], s[right]); // Using built-in C++ function to trade places

        // The "Movement" step
        left++;
        right--;
    }
}

int main(){

    return 0;
}