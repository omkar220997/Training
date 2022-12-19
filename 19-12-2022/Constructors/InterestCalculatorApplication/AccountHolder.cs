using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculatorApplication
{
    internal  class AccountHolder
    {
        private string AccountHolderName;
        private double AccountNumber;
        private string TypeOfAccount;
        private string LoanType;
        private double PrincipleAmount;
        private double RateOfInterest;
        private double TimeOfLoan;
        private List<AccountHolder> AccountHolderInfos = new List<AccountHolder>();

        private AccountHolder()
        {
            Console.WriteLine("Enter the name of Account Holder");
            AccountHolderName =Console.ReadLine();
            Console.WriteLine("Enter the Account Number of Account Holder");
            string AccountNumberstr =Console.ReadLine();
            AccountNumber = Convert.ToDouble(AccountNumberstr);
            Console.WriteLine("Enter the Type of Account of Account Holder");
            TypeOfAccount =Console.ReadLine();
            Console.WriteLine("Enter the Type of Loan taken by Account Holder");
            LoanType =Console.ReadLine(); 
            Console.WriteLine("Enter the Principle Amount of Loan ");
            string PrincipleAmountstr = Console.ReadLine();
            PrincipleAmount = Convert.ToDouble(PrincipleAmountstr);
            Console.WriteLine("Enter the Rate of Interest of Loan ");
            string RateOfIntereststr = Console.ReadLine();
            RateOfInterest = Convert.ToDouble(RateOfIntereststr);  
            Console.WriteLine("Enter the Time of Loan in Years ");
            string TimeOfLoanstr = Console.ReadLine();
            TimeOfLoan = Convert.ToDouble(TimeOfLoanstr);
        }
        
        internal void AccountHolderInfo()
        {
            AccountHolderInfo(AccountHolderName, AccountNumber, TypeOfAccount, LoanType,PrincipleAmount, RateOfInterest,TimeOfLoan);

        }

        internal void AccountHolderInfo(string accountHolderName, double accountNumber,string typeOfAccount,string loanType,double principleAmmount,double rateOfInterest,double timeOfLoan)
        {
            var accountHolderInfo=new AccountHolder();
            accountHolderInfo.AccountHolderName = accountHolderName;
            accountHolderInfo.AccountNumber = accountNumber;
            accountHolderInfo.TypeOfAccount = typeOfAccount;
            accountHolderInfo.LoanType = loanType;
            accountHolderInfo.PrincipleAmount= principleAmmount;
            accountHolderInfo.RateOfInterest= rateOfInterest;
            accountHolderInfo.TimeOfLoan= timeOfLoan;
            AccountHolderInfos.Add(accountHolderInfo);
            Console.WriteLine("Details of " + accountHolderInfo.AccountHolderName + " is added");

        }
        private string CalculationOfInterest()
        {
            double InterestAmount = (PrincipleAmount * RateOfInterest * TimeOfLoan) / 100;
            
            return "The Interest amount is " + Convert.ToString(InterestAmount);

        }

        internal void LoanDetails()
        {
            Console.WriteLine("Name of Account Holder is " +AccountHolderName);
            Console.WriteLine("Account Number of Account Holder is " +AccountNumber);
            Console.WriteLine("Type of Account of  Account Holder is " + TypeOfAccount);
            Console.WriteLine("Type of Loan taken by  Account Holder is " + LoanType);
            Console.WriteLine($"{AccountHolderName} took {PrincipleAmount} of loan for {TimeOfLoan} years at the rate of interst is {RateOfInterest} ");
            CalculationOfInterest();
        }

        



    }
}
