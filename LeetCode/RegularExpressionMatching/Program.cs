using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionMatching
{
    internal class Program
    {
        public bool IsMatch(string InputString,string Pattern)
        {
            bool Match = true;
            
            for (int j = 0; j < Pattern.Length; j++)
            {
                if (Pattern.Contains(".*"))
                {
                    for (int i = 0; i < InputString.Length; i++)
                    {
                        if (InputString != "")
                        {
                            return Match;
                        }
                        else
                        {
                            Match = false;
                            return Match;
                        }

                    }

                }
                else if (Pattern.Contains("."))
                {
                    for(int i = 0; i < InputString.Length; i++)
                    {
                        if (InputString.Contains(Pattern[i]))
                        {
                            return Match;
                        }
                        else
                        {
                            Match = false;
                            return Match;
                        }

                    }
                }
                else if (Pattern.Contains("*"))
                {
                    for (int i = 0; i < InputString.Length; i++)
                    {
                        if (InputString.Contains(Pattern[i]))
                        {
                            return Match;
                        }
                        else
                        {
                            Match = false;
                            return Match;
                        }

                    }

                }
                
                else if (Pattern.Equals(InputString))
                {
                    return Match;
                }
                else
                {
                    Match = false;
                    return Match;
                }
            }
            
            return Match;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Input String here");
            string InputString=Console.ReadLine();
            Console.WriteLine("Enter a Pattern here");
            string Pattern = Console.ReadLine();
            int patternLength=Pattern.Length;
            
            Program p = new Program();
            Console.WriteLine(p.IsMatch(InputString, Pattern));
            Console.ReadLine();


        }
    }
}
