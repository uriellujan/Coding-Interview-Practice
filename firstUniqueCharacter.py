def firstUniqueCharacter(s):
    count_map = {}


    for char in s:
        count_map[char] = count_map.get(char, 0) + 1
    
    for index, char in enumerate(s):
        if count_map[char] == 1:
            return index
    
    return -1