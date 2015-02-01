// ### Problem 2. Print Company Information
// * A company has name, address, phone number, fax number, web site and manager. 
//   The manager has first name, last name, age and a phone number.
// * Write a program that reads the information about a company and its manager 
//   and prints it back on the console.
// 
// _Example input:_
// 
// |       program       |            user            |
// |---------------------|----------------------------|
// | Company name:       | Telerik Academy            |
// | Company address:    | 31 Al. Malinov, Sofia      |
// | Phone number:       | +359 888 55 55 555         |
// | Fax number:         | 2                          |
// | Web site:           | http://telerikacademy.com/ |
// | Manager first name: | Nikolay                    |
// | Manager last name:  | Kostov                     |
// | Manager age:        | 25                         |
// | Manager phone:      | +359 2 981 981             |
// 
// _Example output:_
// 
// Telerik Academy
// Address: 231 Al. Malinov, Sofia
// Tel. +359 888 55 55 555
// Fax: (no fax)
// Web site: http://telerikacademy.com/
// Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)	

namespace _02.PrintCompanyInformation
{
    using System;
    using System.Text.RegularExpressions;

    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            string companyName;
            string companyAddress;
            string companyPhoneNum;
            string companyFaxNum;
            string companyWebSite;
            string managerFirstName;
            string managerLastName;
            byte managerAge;
            string managerPhoneNumber;
            string inputStr;
            bool isValidFaxNum;

            Console.Write("company name: ");
            companyName = Console.ReadLine();
            Console.Write("company address: ");
            companyAddress = Console.ReadLine();
            Console.Write("company phone number: ");
            companyPhoneNum = Console.ReadLine();
            Console.Write("company fax number: ");
            companyFaxNum = Console.ReadLine();
            Console.Write("company website: ");
            companyWebSite = Console.ReadLine();
            Console.Write("mangager first name: ");
            managerFirstName = Console.ReadLine();
            Console.Write("manager last name: ");
            managerLastName = Console.ReadLine();
            Console.Write("manager age: ");
            inputStr = Console.ReadLine();
            managerAge = Convert.ToByte(inputStr);
            Console.Write("manager phone number: ");
            managerPhoneNumber = Console.ReadLine();

            // validate the start of the fax number - the format is:
            // +(country code) (area code) (fax number)
            isValidFaxNum = Regex.IsMatch(companyFaxNum, @"^[+]?[0-9]{1,3}\s[0-9]{1,3}\s");

            if (isValidFaxNum == false)
            {
                companyFaxNum = "(no fax)";
            }

            Console.WriteLine();
            Console.WriteLine(
                "{0}\n" +
                "Address: {1}\n" + 
                "Tel.{2}\n" +
                "Fax: {3}\n" + 
                "Web site: {4}\n" +
                "Manager: {5} {6} (age: {7}, tel. {8})",
                companyName, companyAddress, companyPhoneNum, companyFaxNum, companyWebSite,
                managerFirstName, managerLastName, managerAge, managerPhoneNumber);
        }
    }
}
