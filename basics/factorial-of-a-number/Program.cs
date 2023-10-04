internal class Program
{
    private static void Main(string[] args)
    {
        int number;
        int result=1;

        Console.Write("Enter a number to find factorial: ");
        number = Convert.ToInt32(Console.ReadLine());

        for(int i=number; i>0; i--){
            result *= i;
        }

        Console.WriteLine($"The factorial of {number} is: " + result );
    }
}