import java.util.*;

public class Program{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter input string: ");
        String input = sc.nextLine();
        System.out.println("The transformed output is: " + transformWord(input));
        sc.close();
    }

    static String transformWord(String input){
        String[] words = input.split(" ");
        StringBuilder result = new StringBuilder();

        for(String word: words){
            int wordLength = word.length();
            char firstChar = word.charAt(0);
            char lastChar = word.charAt(wordLength - 1);

            String translated = lastChar + word.substring(1, wordLength-1) + firstChar;
            result.append(translated).append(" ");
        }
        return result.toString();
    }
}