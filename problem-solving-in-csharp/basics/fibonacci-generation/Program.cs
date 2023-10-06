internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Enter the number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());
        int firstTerm = 0;
        int secondTerm = 1;

        System.Console.WriteLine($"The fibonacci sequence of term {terms} are: ");

        if(terms == 0 || terms == 1){
            System.Console.WriteLine(0);
        }
        else if(terms >1){
            for(int i =0; i<terms; i++){
                System.Console.WriteLine(firstTerm);

                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
        }
    }
}