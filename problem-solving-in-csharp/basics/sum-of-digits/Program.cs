using System.Net.Security;

internal class Program
{
    private static void Main(string[] args)
    {
        int sum =0;

        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int num = number;

        while (num > 0){
            int rem = num%10;
            sum += rem;
            num /= 10;
        }

        System.Console.WriteLine($"The sum of digit of number {number} is: " + sum);
    }
}