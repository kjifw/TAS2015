// Problem 7. Encode/decode
// * Write a program that encodes and decodes a string using given encryption key (cipher).
// * The key consists of a sequence of characters.
// * The encoding/decoding is done by performing XOR (exclusive or) operation 
//   over the first letter of the string with the first of the key, the second – 
//   with the second, etc. When the last key character is reached, the next is the first.


namespace _07.EncodeDecode
{
    using System;
    using System.Text;

    class EncodeDecode
    {
        static void Main(string[] args)
        {
//            string cipher = "xJp32d2pWFRq";
//            string text = @"Lorem ipsum dolod tit amet, consectetur adipiscing elit. 
//                            Aenean consequat id lorol sed varius. Fusce egestas dictum nunc et mollis. 
//                            Donec elementum libero velit, teget ullamcorper est maximus ut. 
//                            Suspendisse condimentum lamal pellentesque lebel et porttitor. Aenean ut semper eros.";

            string text = Console.ReadLine();
            string cipher = Console.ReadLine();

            string result;

            result = EncodeDecodeText(text, cipher);

            Console.WriteLine();
            Console.WriteLine("encoded");
            Console.WriteLine();
            Console.WriteLine(result);
            Console.WriteLine();

            result = EncodeDecodeText(result, cipher);

            Console.WriteLine("decoded");
            Console.WriteLine();
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("is encoding/decoding correct: {0}", 
                string.Compare(text, result) == 0 ? true : false);
        }

        private static string EncodeDecodeText(string text, string cipher)
        {
            StringBuilder encoded = new StringBuilder();

            int cipherCounter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (cipherCounter >= cipher.Length)
                {
                    cipherCounter = 0;
                }

                int currentEncodedSymbol = text[i] ^ cipher[cipherCounter];
                cipherCounter++;

                encoded.Append((char)currentEncodedSymbol);
            }

            return encoded.ToString();
        }
    }
}
