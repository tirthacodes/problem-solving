import java.util.*;

class Program{
    public static int add(int a, int b){
        int result = a+b;
        return result;
    }
    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);

        System.out.println("Enter two numbers: ");
        int num1 = sc.nextInt();
        int num2 = sc.nextInt();

        int result = add(num1, num2);
        System.out.println("Sum of " + num1 + " and " + num2 + " is: " + result);

        sc.close();

    }
}