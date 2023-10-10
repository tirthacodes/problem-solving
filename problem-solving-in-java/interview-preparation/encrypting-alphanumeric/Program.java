import java.util.*;

class Program{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a string");
        String str = sc.nextLine();

        var encrypted = encrypt(str);
        System.out.println("Encrypted version: " + encrypted);
        
        sc.close();
    }
    
    public static String encrypt(String str){
        int num, up;
        char ch;
        char[] charArray = str.toCharArray();
        char[] newArray = new char[100];
        for(int i=0; i<str.length(); i++){
            num = (int) charArray[i];
            if((num>=65 && num<=90) || (num>=97 && num<=122) ){
                up = num + 5;
                if((num>=65 && num<=90)){
                    up = up +32;
                    if(up>122){
                        int x = up-122;
                        up = 97+(x-1);
                    }
                }
                else if((num>=97 && num<=122)){
                    up = up -32;
                    if(up>90){
                        int x = up-90;
                        up = 65+(x-1);
                    }
                }
                ch = (char) up;
            }
            else{
                up = num;
                if((num>=48) && (num<=57)){
                    up = num + 5;
                    if(up>57){
                        int x = up - 57;
                        up = 48 + (x-1);
                    }
                }
                ch = (char) up;
            }

            newArray[i] = ch;
        }
        String st = new String(newArray);
        return st;
    }
}