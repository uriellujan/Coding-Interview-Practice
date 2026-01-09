# This program shows the solution for a frequency (How many N?) or
# Find the duplicate probelems using Python, or Two Sum. This solution uses a
# Hash map/Dictionary, to store data.

# This specific problem: Find the First Unique Character
# Input: "statistics"
# Output: 'a' 
# (because a is the first unique character. 'c' is also unique but it is
# NOT first)

# Time Complexity: 2N == O(N)
# Space Complexity: O(1)

def firstUniqueCharacter(s):
    # Step 1: Create a Hash Map
    # This hash map will store character frequency e.g., {'s': 3, 't':3, ...}
    count_map = {}

    # Fill/Populate the map with the program Input
    for char in s:
        # If char is in count_map, add 1. If not, set to 1.
        count_map[char] = count_map.get(char, 0) + 1
    
    # Step 2: Now that we have frequency counts for the Input,
    # return the first index equal to 1 by looping through the STRING,
    # NOT THE MAP to preserve the order.
    for index, char in enumerate(s):
        if count_map[char] == 1:
            return index # Once we find the first unique character, IMMEDIATELY return it.
    
    return -1 # If we finish the loop without finding a unique character, return -1