// Problem 1. StringBuilder.Substring
// * Implement an extension method Substring(int index, int length) 
//   for the class StringBuilder that returns new StringBuilder and has 
//   the same functionality as Substring in the class String.

namespace _01.StringBuilderExtentions
{
    using System;
    using System.Text;

    class StringBuilderExtentionsTest
    {
        static void Main(string[] args)
        {
            int index = 2;
            int length = 12;
            StringBuilder info = new StringBuilder();
            info.Append("some ");
            info.Append("usefull ");
            info.Append("information");

            string infoAsStr = "some usefull information";

            StringBuilder sub = info.SubStringBuilder(index, length);

            Console.WriteLine(sub);
            Console.WriteLine(infoAsStr.Substring(index, length));
        }
    }
}
