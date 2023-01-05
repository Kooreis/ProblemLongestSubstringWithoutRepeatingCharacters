Here is a Java console application that solves the problem:

```java
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a string:");
        String input = scanner.nextLine();
        System.out.println("Longest substring without repeating characters is: " + longestSubstring(input));
    }

    private static String longestSubstring(String str) {
        Map<Character, Integer> visited = new HashMap<>();
        String output = "";

        for (int start = 0, end = 0; end < str.length(); end++) {
            char currChar = str.charAt(end);
            if (visited.containsKey(currChar)) {
                start = Math.max(visited.get(currChar)+1, start);
            }
            if (output.length() < end - start + 1) {
                output = str.substring(start, end + 1);
            }
            visited.put(currChar, end);
        }
        return output;
    }
}
```

This console application reads a string from the user, then finds and prints the longest substring without repeating characters. The `longestSubstring` method uses a sliding window approach, where it keeps expanding the window until it encounters a repeated character. When a repeated character is found, it moves the start of the window to the right. It also keeps track of the longest substring it has found so far.