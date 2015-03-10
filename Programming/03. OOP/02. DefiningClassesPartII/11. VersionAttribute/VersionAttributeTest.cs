// Problem 11. Version attribute
// * Create a [Version] attribute that can be applied to structures, classes, 
//   interfaces, enumerations and methods and holds a version in the format 
//   major.minor (e.g. 2.11).
// * Apply the version attribute to a sample class and display its version at runtime.

namespace _11.VersionAttribute
{
    using System;
    using System.Reflection;

    [VersionAttribute(1, 17)]
    enum DaysOfTheWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    [VersionAttribute(2, 11)]
    class VersionAttributeTest
    {
        static void Main(string[] args)
        {
            Type currentType = typeof(VersionAttributeTest);
            object[] allAttributes = currentType.GetCustomAttributes(false);

            foreach (var item in allAttributes)
            {
                Console.WriteLine(item);
            }

            currentType = typeof(DaysOfTheWeek);
            allAttributes = currentType.GetCustomAttributes(false);

            foreach (var item in allAttributes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
