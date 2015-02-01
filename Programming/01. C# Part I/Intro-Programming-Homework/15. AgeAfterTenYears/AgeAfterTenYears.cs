// ### Problem 15.* Age after 10 Years
// * Write a program to read your birthday from the console and print 
// how old you are now and how old you will be after 10 years.

namespace _15.AgeAfterTenYears
{
    using System;

    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            string[] inputStr;
            DateTime currentDate = DateTime.Now;
            DateTime dateOfBirth;
            int age;

            Console.Write("Input birthdate in format dd/mm/yyyy or format dd.mm.yyyy: ");
            inputStr = Console.ReadLine().Split(new char[] { '/', '.' }, StringSplitOptions.RemoveEmptyEntries);

            dateOfBirth = new DateTime(
                Convert.ToInt32(inputStr[2]),
                Convert.ToInt32(inputStr[1]),
                Convert.ToInt32(inputStr[0]));

            age = currentDate.Year - dateOfBirth.Year;
            
            if (currentDate.DayOfYear < dateOfBirth.DayOfYear)
            {
                age -= 1;
            }

            age += 10;
            Console.WriteLine("Age after 10 years at present date: {0}", age);
        }
    }
}
