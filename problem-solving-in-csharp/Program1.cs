//Character Substitution Cipher

//Write a program that encrypts an alphanumeric input string. The encryption should shift each letter or number by a fixed amount (e.g., 3 positions), maintaining the original case for letters and wrapping around the alphabet (A-Z or a-z) or digits (0-9) as necessary. Any other characters in the input should remain unchanged.

//Example:

//Input: Hello123World!
//Output: Khoor456Zruog!


using System;
using System.Text;

public class CharacterSubstitution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to encrypt:");
        string input = Console.ReadLine();

        string encryptedString = EncryptString(input, 3);
        Console.WriteLine($"Encrypted: {encryptedString}");
    }

    public static string EncryptString(string input, int shift)
    {
        StringBuilder result = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';
                char shiftedChar = (char)(baseChar + (c - baseChar + shift) % 26);
                result.Append(shiftedChar);
            }
            else if (char.IsDigit(c))
            {
                char shiftedDigit = (char)('0' + (c - '0' + shift) % 10);
                result.Append(shiftedDigit);
            }
            else
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }
}
