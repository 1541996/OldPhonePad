using System;
using System.Text;

public class Phone
{
    private static readonly string[] KeyPad =
    {
        "",    
        "",   
        "ABC",
        "DEF",  
        "GHI",  
        "JKL", 
        "MNO", 
        "PQRS", 
        "TUV", 
        "WXYZ" 
    };

    public static string OldPhonePad(string input)
    {
        List<char> result = new List<char>();
        int i = 0;

        while (i < input.Length)
        {
            char currentChar = input[i];

            if (currentChar == '#')
            {
                break; // End input
            }
            else if (currentChar == '*')
            {
                if (result.Count > 0)
                {
                    result.RemoveAt(result.Count - 1); // Remove last character
                }
                i++;
            }
            else if (char.IsDigit(currentChar) && currentChar >= '2' && currentChar <= '9')
            {
                int count = 1; 
                while (i + 1 < input.Length && input[i + 1] == currentChar)
                {
                    count++;
                    i++;
                }

                string letters = KeyPad[currentChar - '0'];
                if (letters.Length > 0)
                {
                    int index = 0;
                    while (count > letters.Length)
                    {
                        count -= letters.Length; 
                    }
                    index = count - 1;
                    result.Add(letters[index]);
                }
                i++;
            }
            else
            {
                i++; // Skip invalid characters
            }
        }

        return new string(result.ToArray());
    }

    public static void Main()
    {
        Console.WriteLine(OldPhonePad("33#")); // Output: E
        Console.WriteLine(OldPhonePad("227*#")); // Output: B
        Console.WriteLine(OldPhonePad("4433555 555666#")); // Output: HELLO
        Console.WriteLine(OldPhonePad("8 88777444666*664#")); 
    }
}

