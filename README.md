# Question: How do you find the longest substring without repeating characters? C# Summary

The C# console application prompts the user to input a string, then it identifies and outputs the longest substring that does not contain any repeating characters. The application uses a function called `LongestSubstring` to achieve this. This function employs a sliding window technique, which involves tracking the last index of each character in the string. If a character is found to be repeated, the start of the window is shifted to the character that follows the repeated one. The function continuously updates the longest substring each time it identifies a longer one.

---

# Python Differences

The Python version of the solution is quite similar to the C# version in terms of logic and approach. Both use a sliding window approach and a dictionary to keep track of the last index of each character in the string. If a character is repeated, the start of the window is moved to the next character after the repeated one. The longest substring is updated whenever a longer one is found.

However, there are some differences due to the language features and syntax:

1. In Python, the `input()` function is used to get user input, while in C#, `Console.ReadLine()` is used.

2. Python uses `len(s)` to get the length of the string, while C# uses `s.Length`.

3. Python uses `in` keyword to check if a character is in the dictionary, while C# uses `ContainsKey()` method.

4. Python uses `max()` function to get the maximum of two numbers, while C# uses `Math.Max()`.

5. The Python version returns the length of the longest substring without repeating characters, while the C# version returns the actual substring.

6. Python uses a `main()` function to encapsulate the main logic of the program, and uses the `if __name__ == "__main__":` idiom to ensure that `main()` is run when the script is run directly, but not when the module is imported by other scripts. C# uses a `Main()` method in a `Program` class, which is the entry point of the application.

7. Python uses `print()` function to output the result, while C# uses `Console.WriteLine()`.

---

# Java Differences

Both the C# and Java versions solve the problem using a similar approach. They both use a sliding window technique and a dictionary (or map in Java) to keep track of the last index of each character in the string. When a repeated character is found, the start of the window is moved to the next character after the repeated one. The longest substring is updated whenever a longer one is found.

The main differences between the two versions are due to the differences in the languages themselves:

1. User Input: In C#, the Console.ReadLine() method is used to get user input, while in Java, a Scanner object is used.

2. Dictionary/Map: In C#, a Dictionary is used to store the last index of each character, while in Java, a HashMap is used. The methods to check if a key exists in the dictionary/map and to get the value associated with a key are also named differently in the two languages (ContainsKey and get in C# and Java respectively).

3. String Manipulation: In C#, the Substring method is used to get a substring from the string, while in Java, the substring method is used. The Java substring method uses end index exclusive, while C# Substring method uses length of the substring.

4. Variable Declaration: In Java, multiple variables of the same type can be declared and initialized in the same line (for example, "int start = 0, end = 0;"). This is not done in the C# version.

5. Method Declaration: In C#, the method is declared as static, while in Java, it's declared as private. This is because in the C# version, the method is called from a static context (the Main method), while in the Java version, it's called from an instance context (the main method).

---
