internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        int b;
        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        var result = a + b;
        Console.WriteLine("Result : " + result);
    }
}