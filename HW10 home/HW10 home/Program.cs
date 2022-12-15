using System;

namespace HW10_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(trimLeftRight("  salam  necesen  "));
        }

        // task 1 Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod
        static int firstNonSpace(string str)
        {
            
            for(int i=0; i<str.Length; i++) 
            {
                if (str[i] != ' ')
                {
                    return i;
                }
            }
            return -1;

        }

        // task 2 Verilmiş yazıdaki son boşluq olmayan index-i qaytaran metod --salam--

        static int lastNonSpace(string str)
        {

            for (int i = str.Length-1 ; i >=0 ; i--)
            {
                if (str[i] != ' ')
                {
                    return i;
                }
            }
            return -1;

        }

        // task 3 Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string trimLeft(string str)
        {
            string newWord = "";
            for (int i = firstNonSpace(str); i < str.Length; i++)
            {
                newWord += str[i];
            }
            return newWord;
        }

        // task 4 Verilmiş yazını sol və sağ tərəflərində boşluq olmayan vəziyyətdə qaytaran metod
        static string trimLeftRight (string str)
        {
            string newStr = "";

            for (int i = firstNonSpace(str); i < str.Length; i++)
            {
                if(str.Length-1 != ' ')
                {
                    newStr += str[i];
                }    
            }
            return newStr;

        }
    }
}
