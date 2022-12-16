using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // StringBuilder Append Method
            /*Console.WriteLine("Append and AppendLine methods")
            StringBuilder StringAppend = new StringBuilder("Hello ", 40);
            StringAppend.Append("Omkar ");
            StringAppend.AppendLine("Kadam");
            StringAppend.Append("Good Morning");
            Console.WriteLine(StringAppend);*/

            // StringBuilder AppendFormat()
            /*Console.WriteLine("AppendFormat Method");
            StringBuilder StringAppendFormat = new StringBuilder("Your achieved Score is ");
            StringAppendFormat.AppendFormat("{0:D} ", 80);
            Console.WriteLine(StringAppendFormat);*/

            //StringBilder insert() method
            /* Console.WriteLine("String Builder insert method ");
             StringBuilder StringBuilderIndex=new StringBuilder("My name is Omkar Kadam");
             StringBuilderIndex.Insert(16, " Sunil ");
             Console.WriteLine(StringBuilderIndex); */

            // String Builder Remove method
            /* Console.WriteLine("String builder Remove Method");
            StringBuilder StringBuilderRemove=new StringBuilder("My name is Omkar Sunil Kadam");
            StringBuilderRemove.Remove(17, 6);
            Console.WriteLine(StringBuilderRemove); */

            // String Builder Replace Method
            Console.WriteLine("String Builder Replce Method");
            StringBuilder StringBuilderReplace=new StringBuilder("My mobile number is 9022528403");
            StringBuilderReplace.Replace("9022528403", "8080770371");
            Console.WriteLine(StringBuilderReplace);
            Console.ReadLine();

        }
    }
}
