using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculatorApplication
{
    internal class Program
    {

        static void Main(string[] args)
        {

            bool entry =true;
            while (entry)
            {
                Console.WriteLine("Enter 'Add' for Make Entry of Loan, 'Loan Details' to See Deatils of loans or 'Quit' to exit from application");

                var Action =Console.ReadLine();
                if (Action == "Add")
                {
                    bool entry2=true;
                    while (entry2)
                    {
                       AccountHolder account = new AccountHolder("Adding Details");
                        account.AccountHolderInfo();
                        entry2 = false;
                    }
                }
                else if(Action == "Loan Details")
                {
                    bool entry3 = true;
                    while (entry3)
                    {
                        AccountHolder account = new AccountHolder("Showing Details");
                        account.LoanDetails();
                        entry3 = false;
                    }

                }
                else if( Action == "Quit")
                {
                   entry = false;
                }
                else
                {
                    Console.WriteLine("Enter a Valid command");
                }

               

            }
            Console.ReadLine();

        }
    }
}
