import java.util.*;

public class Program{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a string: ");
        String input = sc.nextLine();
        System.out.println("The transformed string is: " + findFirstNonRepeatingChar(input));
        sc.close();
    }

    public static char findFirstNonRepeatingChar(String input){
        int[] frequency = new int[26]; // Assuming only lowercase letters

        // Build frequency array
        for (char c : input.toCharArray()) {
            frequency[c - 'a']++;
        }

        // Iterate through the string again
        for (char c : input.toCharArray()) {
            if (frequency[c - 'a'] == 1) {
                return c;
            }
        }

        return '-';
    }
}