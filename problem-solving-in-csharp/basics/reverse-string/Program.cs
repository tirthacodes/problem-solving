internal class Program
{
    private static void Main(string[] args)
    {
        try{
            int rev = 0;
            Console.Write("write a string: ");
            string? str = Console.ReadLine();

            if(str != null){
                char[] chars = str.ToCharArray();
                char[] reverse = new char[str.Length+1];
                for(int i=str.Length; i>0; i--){
                    reverse[i] = chars[rev];
                    rev++;
                }
                string reversed = new string(reverse);
                System.Console.WriteLine(reversed);
            }
        }
        catch(Exception ex){
            System.Console.WriteLine("Error! " + ex.Message);
        }     
    }
}