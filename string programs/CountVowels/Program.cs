using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string here");
            string InputString=Console.ReadLine();
            int LengthOfString=InputString.Length;
            int vowel=0, Consonants=0;
            for(int i=0; i<LengthOfString; i++)
            {
                if(InputString[i] == 'a' || InputString[i]=='e'|| InputString[i] == 'i' || InputString[i] == 'o'|| InputString[i] == 'u' || InputString[i] == 'A'|| InputString[i] == 'E' || InputString[i] == 'I'| InputString[i] == 'O' || InputString[i] == 'U')
                {
                    vowel++;
                    Console.WriteLine("Vowel :" +InputString[i]);
                }
                else if (InputString[i] !=' ')
                {
                    Consonants++;
                    Console.WriteLine("Consonants :" +InputString[i]);
                }
                
            }
            Console.WriteLine("Lenght of string is " + LengthOfString);
            Console.WriteLine("Vowel count is " +vowel);
            Console.WriteLine("Consonants count is " +Consonants);
            Console.ReadLine();
        }
    }
}
