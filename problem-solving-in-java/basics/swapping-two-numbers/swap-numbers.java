import java.util.*;

class SwapNumbers{
    int first;
    int second;
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter first numeber: ");
        int first = sc.nextInt();
        System.out.print("Enter second number: ");
        int second = sc.nextInt();

        System.out.println("First number: " + first + "\n" + "Second Number: " + second);
        swap(first, second);

        sc.close();
    }
    public static void swap(int first, int second){
        System.out.println("After swapping: ");
        int temp = first;
        first = second;
        second = temp;
        System.out.println("First number: " + first + "\n" + "Second Number: " + second);
    }
}