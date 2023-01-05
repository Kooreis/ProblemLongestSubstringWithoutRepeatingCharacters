Here is a Python console application that solves the problem:

```python
def longest_substring_without_repeating_characters(s):
    start = maxLength = 0
    usedChar = {}

    for i in range(len(s)):
        if s[i] in usedChar and start <= usedChar[s[i]]:
            start = usedChar[s[i]] + 1
        else:
            maxLength = max(maxLength, i - start + 1)

        usedChar[s[i]] = i

    return maxLength

def main():
    s = input("Enter a string: ")
    print("Length of the longest substring without repeating characters: ", longest_substring_without_repeating_characters(s))

if __name__ == "__main__":
    main()
```

This console application first asks the user to input a string. It then calls the function `longest_substring_without_repeating_characters(s)` with the input string. This function uses a sliding window approach to find the longest substring without repeating characters. It keeps track of the already visited characters with their indices in a dictionary. If a character is already in the dictionary, it means the character is repeating in the current window so it changes the start of the window. The length of the maximum window encountered while traversing is the answer.