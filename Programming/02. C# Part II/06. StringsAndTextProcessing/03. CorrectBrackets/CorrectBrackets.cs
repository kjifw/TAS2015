// Problem 3. Correct brackets
// * Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

namespace _03.CorrectBrackets
{
    using System;

    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string expression;
            bool isCorrectExpression;

            expression = Console.ReadLine();

            isCorrectExpression = IsCorrectBrackets(expression);

            Console.WriteLine(isCorrectExpression);
        }

        private static bool IsCorrectBrackets(string expression)
        {
            bool result = false;
            int brackets = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(' && brackets >= 0)
                {
                    brackets++;     
                }

                if (expression[i] == ')' && brackets >= 0)
                {
                    brackets--;
                }
            }

            if (brackets == 0)
            {
                result = true;
            }

            return result;
        }
    }
}
