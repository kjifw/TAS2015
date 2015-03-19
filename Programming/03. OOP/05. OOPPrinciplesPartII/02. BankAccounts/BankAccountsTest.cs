//Problem 2. Bank accounts
// * A bank holds different types of accounts for its customers: deposit accounts, 
//   loan accounts and mortgage accounts. Customers could be individuals or companies.
// * All accounts have customer, balance and interest rate (monthly based).
//   - Deposit accounts are allowed to deposit and with draw money.
//   - Loan and mortgage accounts can only deposit money.
// * All accounts can calculate their interest amount for a given period (in months). 
//   In the common case its is calculated as follows: number_of_months * interest_rate.
// * Loan accounts have no interest for the first 3 months if are held by individuals and 
//   for the first 2 months if are held by a company.
// * Deposit accounts have no interest if their balance is positive and less than 1000.
// * Mortgage accounts have ½ interest for the first 12 months for companies and no interest 
//   for the first 6 months for individuals.
// * Your task is to write a program to model the bank system by classes and interfaces.
// * You should identify the classes, interfaces, base classes and abstract actions and implement 
//   the calculation of the interest functionality through overridden methods.

namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;

    class BankAccountsTest
    {
        static void Main(string[] args)
        {
            Bank currentBank = new Bank("My Bank");

            DepositAccount depositAcc = new DepositAccount(new IndividualCustomer("pesho"), 3564.0m, 15);

            LoanAccount loanAcc = new LoanAccount(new CompanyCustomer("gosho inc."), 55678.54m, 22);

            MortgageAccount mortgageAcc = new MortgageAccount(new IndividualCustomer("tosho"), 21354.66m, 17);

            depositAcc.DepositMoney(150);
            depositAcc.WithdrawMoney(50);

            loanAcc.DepositMoney(200);

            mortgageAcc.DepositMoney(500);

            currentBank.AddAccount(depositAcc);
            currentBank.AddAccount(loanAcc);
            currentBank.AddAccount(mortgageAcc);

            //Console.WriteLine(currentBank);
            
            int numberOfMonths = 14;

            decimal calcInterest = depositAcc.CalculateInterest(numberOfMonths);
            Console.WriteLine(depositAcc + "calculated interest: {0:C3}", calcInterest);

            calcInterest = loanAcc.CalculateInterest(numberOfMonths);
            Console.WriteLine(loanAcc + "calculated interest: {0:C3}", calcInterest);

            calcInterest = mortgageAcc.CalculateInterest(numberOfMonths);
            Console.WriteLine(mortgageAcc + "calculated interest: {0:C3}", calcInterest);
        }
    }
}
