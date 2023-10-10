//Write a program that compares the two cards and determines which card is greater based on the following hierarchy:

// Ace (A) > King (K) > Queen (Q) > Jack (J) > 10 > 9 > 8 > 7 > 6 > 5 > 4 > 3 > 2.
import java.util.*;
public class Program{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the first card: ");
        String card1 = sc.next();
        System.out.println("Enter the second card: ");
        String card2 = sc.next();

        System.out.println(compareCards(card1, card2));
        sc.close();
    }

    static String compareCards(String card1, String card2){
        String[] rankedCards = {"2","3","4","5","6","7","8","9","J","Q","K","A"};

        int card1Index = Arrays.asList(rankedCards).indexOf(card1.toUpperCase());
        int card2Index = Arrays.asList(rankedCards).indexOf(card2.toUpperCase());

        if((card1Index == -1) || (card2Index == -1)){
            return "Invalid Input";
        }
        else{
            if(card1Index>card2Index){
                return "The greater card is " + card1;
            }
            else if(card2Index>card1Index){
                return "The greater card is " + card2;
            }
            else{
                return "Equal Cards";
            }
        }
        
    }
}