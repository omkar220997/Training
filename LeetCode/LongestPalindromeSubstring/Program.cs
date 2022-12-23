using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromeSubstring
{
    internal class Program
    {
        public string LongestPalindrome(string s)
        {
            string SubString=string.Empty;
            string ReverseSubString="";
            for (int i = 0; i < s.Length + 1; i++)
            {
                for (int j = 0; j < s.Length + 1 - i; j++)
                {
                    SubString = s.Substring(i, j);
                    //Console.WriteLine($"Substring started from {i} to {j} is {SubString}");
                    int len = SubString.Length - 1;
                    ReverseSubString = string.Empty;
                    int length = 0;
                    while (len >= 0)
                    {

                        ReverseSubString += SubString[len];
                        len--;

                    }
                    //Console.WriteLine("reverse of substring is " + ReverseSubString);
                    if(SubString.Length > length)
                    {
                         length= SubString.Length;
                        if(SubString!=""&& ReverseSubString.Equals(SubString))
                        {
                            Console.WriteLine("Longest Palindromew Substring is " +SubString);
                        }
                    }

                }

            }
           
            return SubString;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string s = "abcdcbef";
            p.LongestPalindrome(s);

            Console.ReadLine();
        }
    }
}
