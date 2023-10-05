using cs = System.Console;
internal class Program
{
    static bool IsPrime(int num){
        if(num<=1){
            return false;
        }
        if(num == 2){
            return true;
        }
        if(num%2 == 0){
            return false;
        }

        for(int i=3; i<num; i++){
            if(num%i == 0){
                return false;
            }
        }
        return true;
    }
    private static void Main(string[] args)
    {
        while(true){
            int num;
            cs.Write("Enter a number to check prime or not: ");
            num = Convert.ToInt32(cs.ReadLine());

            if(IsPrime(num)){
                cs.WriteLine($"{num} is a prime number");
            }
            else{
                cs.WriteLine($"{num} is NOT a prime number");
            }
        }
        
    }
}