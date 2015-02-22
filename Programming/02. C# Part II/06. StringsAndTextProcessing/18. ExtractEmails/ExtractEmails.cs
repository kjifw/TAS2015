// Problem 18. Extract e-mails
// * Write a program for extracting all email addresses from given text.
// * All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace _18.ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ExtractEmails
    {
        static void Main(string[] args)
        {
            List<string> emails = new List<string>();
            string text; //= "My new email is fake@mail.never in the new never domain. There is no turning back now. Create your some@email.never.";

            text = Console.ReadLine();

            emails = ExtractAllEmails(text);

            foreach (var item in emails)
            {
                Console.WriteLine(item);   
            }
        }

        private static List<string> ExtractAllEmails(string text)
        {
            List<string> emailsList = new List<string>();
            MatchCollection emails = Regex.Matches(text, @"(.*?)(\w+@\w+.\w+)(.*?)");
            
            foreach (Match item in emails)
            {
                emailsList.Add(item.Groups[2].Value);
            }

            return emailsList;
        }
    }
}
