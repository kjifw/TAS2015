// ### Problem 11. Bank Account Data
// * A bank account has a holder name (first name, middle name and last name), 
//   available amount of money (balance), bank name, IBAN, 3 credit card numbers 
//   associated with the account.
// * Declare the variables needed to keep the information for a single bank account 
//   using the appropriate data types and descriptive names.

namespace _11.BankAccountData
{
    using System;

    class BankAccountData
    {
        static void Main(string[] args)
        {
            string accHolderFirstName;
            string accHolderMidName;
            string accHolderLastName;
            decimal accBalance;
            string bankName;
            string iban;
            long firstCreditCardNum;
            long secondCreditCardNum; 
            long thirdCreditCardNum;
            string inputStr;

            Console.Write("Input account holder first name: ");
            accHolderFirstName = Console.ReadLine();
            Console.Write("Input account holder middle name: ");
            accHolderMidName = Console.ReadLine();
            Console.Write("Input account holder last name: ");
            accHolderLastName = Console.ReadLine();
            Console.Write("Input account balance: ");
            inputStr = Console.ReadLine();
            accBalance = Convert.ToDecimal(inputStr);
            Console.Write("Input bank name: ");
            bankName = Console.ReadLine();
            Console.Write("Input IBAN: ");
            iban = Console.ReadLine();
            Console.Write("Input first credit card number: ");
            inputStr = Console.ReadLine();
            firstCreditCardNum = Convert.ToInt64(inputStr);
            Console.Write("Input second credit card number: ");
            inputStr = Console.ReadLine();
            secondCreditCardNum = Convert.ToInt64(inputStr);
            Console.Write("Input third credit card number: ");
            inputStr = Console.ReadLine();
            thirdCreditCardNum = Convert.ToInt64(inputStr);

            Console.WriteLine();

            Console.WriteLine(
                "Holder names: {0} {1} {2}", 
                accHolderFirstName, 
                accHolderMidName, 
                accHolderLastName);
            Console.WriteLine("Account balance: {0}", accBalance);
            Console.WriteLine("Bank name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("Credit card numbers: ");
            Console.WriteLine("first: {0}", firstCreditCardNum);
            Console.WriteLine("second: {0}", secondCreditCardNum);
            Console.WriteLine("third: {0}", thirdCreditCardNum);
        }
    }
}
