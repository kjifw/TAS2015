
namespace _04.DecodeAndDecrypt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class DecodeAndDecrypt
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string decoded = Decode(text);

            string decrypted = Decrypt(decoded);

            Console.WriteLine(decrypted);
        }

        private static string Decrypt(string text)
        {
            string result = string.Empty;
            string cypher = string.Empty;
            string cypherLengthDigitsInReverse = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(text[i]))
                {
                    cypherLengthDigitsInReverse += text[i];
                }
                else
                {
                    break;
                }
            }

            string cypherLengthDigits = string.Empty;

            for (int k = cypherLengthDigitsInReverse.Length - 1; k >= 0; k--)
            {
                cypherLengthDigits += cypherLengthDigitsInReverse[k];
            }

            int cypherLength = Convert.ToInt32(cypherLengthDigits);

            cypher = text.Substring(text.Length - cypherLength - cypherLengthDigits.Length, cypherLength);
            text = text.Substring(0, text.Length - cypherLength - cypherLengthDigits.Length);
            
            if (text.Length > cypher.Length)
            {
                int cypherCounter = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (cypherCounter > cypher.Length - 1)
                    {
                        cypherCounter = 0;
                    }

                    int currentDecryptedLetter = (text[i] - 'A') ^ (cypher[cypherCounter] - 'A');
                    currentDecryptedLetter += 'A';

                    result += (char)currentDecryptedLetter;
                    cypherCounter++;
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int cypherCounter = i;
                    int currentDecryptedLetter = text[i];

                    while (cypherCounter < cypher.Length)
                    {
                        currentDecryptedLetter = (currentDecryptedLetter - 'A') ^ (cypher[cypherCounter] - 'A');
                        currentDecryptedLetter += 'A';

                        cypherCounter += text.Length;
                    }

                    result += (char)currentDecryptedLetter;
                }
            }

            return result;
        }

        private static string Decode(string text)
        {
            StringBuilder decoded = new StringBuilder();
            string number = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    number += text[i];
                }
                else
                {
                    if (number != string.Empty)
                    {
                        int num = Convert.ToInt32(number);

                        for (int j = 0; j < num; j++)
                        {
                            decoded.Append(text[i]);
                        }

                        number = string.Empty;
                    }
                    else
                    {
                        decoded.Append(text[i]);
                    }
                }
            }

            decoded.Append(number);

            return decoded.ToString();
        }
    }
}