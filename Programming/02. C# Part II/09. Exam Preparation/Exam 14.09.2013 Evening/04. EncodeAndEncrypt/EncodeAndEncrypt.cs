
namespace _04.EncodeAndEncrypt
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    class EncodeAndEncrypt
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string cypher = Console.ReadLine();

            string result = Encrypt(text, cypher);
            result = Encode(result, cypher);

            Console.WriteLine(result);
        }

        private static string Encode(string text, string cypher)
        {
            string fullText = string.Empty;
            StringBuilder result = new StringBuilder();

            fullText = text + cypher;
            
            int currentIndex = 0;
            while (currentIndex < fullText.Length)
            {
                char currentLetter = fullText[currentIndex];
                int count = 0;
                int nextElementIndex = currentIndex;

                while (nextElementIndex < fullText.Length)
                {
                    char nextLetter = fullText[nextElementIndex];
                    if (nextLetter != currentLetter)
                    {
                        break;
                    }

                    count++;
                    nextElementIndex++;
                }

                currentIndex = nextElementIndex;

                if (count <= 2)
                {
                    result.Append(currentLetter, count);
                }
                else
                {
                    result.Append(count);
                    result.Append(currentLetter);
                }
            }

            return result.ToString() + cypher.Length;
        }

        private static string Encrypt(string text, string cypher)
        {
            string result = string.Empty;

            if (text.Length > cypher.Length)
            {
                int cypherCounter = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (cypherCounter > cypher.Length - 1)
                    {
                        cypherCounter = 0;
                    }

                    int currentEncryptedLetter = (text[i] - 'A') ^ (cypher[cypherCounter] - 'A');
                    currentEncryptedLetter += 'A';

                    result += (char)currentEncryptedLetter;
                    cypherCounter++;
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int cypherCounter = i;
                    int currentEncryptedLetter = text[i];

                    while (cypherCounter < cypher.Length)
                    {
                        currentEncryptedLetter = (currentEncryptedLetter - 'A') ^ (cypher[cypherCounter] - 'A');
                        currentEncryptedLetter += 'A';

                        cypherCounter += text.Length;
                    }

                    result += (char)currentEncryptedLetter;
                }
            }

            return result;
        }
    }
}