// A group of pirates created their own language which is different from normal English. English is translated to the Pirate Language by taking the initial letter of every word, moving it to the end of the word and then adding 'arg'.**

// Write a program that takes a string as an input and prints the translated text to the language of pirates.

import java.util.*;

class Program{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String input;
        input = sc.nextLine();

        System.out.println(logic(input));
        sc.close();
    }

    static String logic(String input) {
        String[] words = input.split(" ");
        StringBuilder result = new StringBuilder();

        for(String word: words){
            int wordLength = word.length();
            char firstChar = word.charAt(0);

            String punc = "";
            int lastIndex = wordLength - 1;

            while(lastIndex >=0 && !Character.isLetter(word.charAt(lastIndex))){
                punc += word.charAt(lastIndex);
                lastIndex--;
            }

            String translatedWord = word.substring(1, lastIndex+1) + firstChar + "arg" + punc;
            result.append(translatedWord).append(" ");            
        }
        return result.toString();
    }   
}