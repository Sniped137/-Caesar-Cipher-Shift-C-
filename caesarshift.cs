using System;
using System.Collections.Generic;
using System.Linq;

class CaesarCipher
{
    static private string GetMessage()
    {   
        Console.WriteLine("Please Type Your Message: ");
        string message = Console.ReadLine().ToUpper();
        return message;
    }


    static private int ShiftLength()
    {
        Console.WriteLine("Please Enter [+] or [-] with the Shift Length: ");
        int shift = Convert.ToInt32(Console.ReadLine());
        return shift;
    }

    static public void Main()
    {
        Dictionary<char, int> alphabet = new Dictionary<char, int>(){
	    {'A', 0},{'B', 1},{'C', 2},{'D', 3},{'E', 4},{'F', 5},
        {'G', 6},{'H', 7},{'I', 8},{'J', 9},{'K', 10},{'L', 11},
        {'M', 12},{'N', 13},{'O', 14},{'P', 15},{'Q', 16},{'R', 17},{'S', 18},
        {'T', 19},{'U', 20},{'V', 21},{'W', 22},{'X', 23}, {'Y', 24},{'Z', 25}
        };

        string result = "";
        string message = GetMessage();
        int shift = ShiftLength();

        foreach (char letter in message)
        {
            if (alphabet.ContainsKey(letter))
            {
                int new_value = alphabet[letter];
                int newlen = new_value + shift;
                int modresult = newlen % 26;
                if (modresult == 0)
                {
                    char char_new_key = alphabet.ElementAt(newlen).Key;
                    string string_new_key = char_new_key.ToString(); 
                    result += string_new_key; 
                }
                else
                {
                    char mod_new_key = alphabet.ElementAt(modresult).Key;
                    string string_mod_new_key = mod_new_key.ToString(); 
                    result += string_mod_new_key;
                }
            }

            if (letter == ' ')
            {
                result += " ";
            }
        }
    
    Console.WriteLine(result);
    }

}