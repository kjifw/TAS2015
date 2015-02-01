// ### Problem 10. Employee Data
// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
// * First name
// * Last name
// * Age (0...100)
// * Gender (m or f)
// * Personal ID number (e.g. 8306112507)
// * Unique employee number (27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate 
// primitive data types. Use descriptive names. Print the data at the console.

namespace _10.EmployeeData
{
    using System;

    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            byte age;
            char gender;
            long personalID;
            short employeeNumberSuffix;
            string employeeNumberPrefix = "2756";
            string inputStr;

            Console.Write("Input first name: ");
            firstName = Console.ReadLine();
            Console.Write("Input last name: ");
            lastName = Console.ReadLine();
            Console.Write("Input age: ");
            inputStr = Console.ReadLine();
            age = Convert.ToByte(inputStr);
            Console.Write("Input gender - m/f: ");
            inputStr = Console.ReadLine();
            gender = inputStr[0];
            Console.Write("Input personal ID: ");
            inputStr = Console.ReadLine();
            personalID = Convert.ToInt64(inputStr);
            Console.Write("Input employee number - 0000 to 9999: ");
            inputStr = Console.ReadLine();
            employeeNumberSuffix = Convert.ToInt16(inputStr);

            Console.WriteLine();

            Console.WriteLine("Employee first name: {0}", firstName);
            Console.WriteLine("Employee last name: {0}", lastName);
            Console.WriteLine("Employee age: {0}", age);
            Console.WriteLine("Employee gender: {0}", gender);
            Console.WriteLine("Employee personal ID: {0}", personalID); 
            Console.WriteLine(
                "Employee emplyee number: {0}", 
                employeeNumberPrefix + employeeNumberSuffix);
        }
    }
}
