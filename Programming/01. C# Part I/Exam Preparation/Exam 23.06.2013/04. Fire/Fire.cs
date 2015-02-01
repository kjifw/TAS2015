
namespace _04.Fire
{
    using System;
    using System.Text;

    class Fire
    {
        static void Main(string[] args)
        {
            string inputStr;
            int n;
            StringBuilder output = new StringBuilder();

            inputStr = Console.ReadLine();
            n = Convert.ToInt32(inputStr);



            //...##...
            //..#..#..
            //.#....#.
            //#......#

            for (int row = 0; row < n / 2; row++)
            {
                for (int i = 0; i < n / 2 - row - 1; i++)
                {
                    output.Append(".");
                }

                output.Append("#");

                for (int i = 0; i < 2 * row; i++)
                {
                    output.Append(".");
                }

                output.Append("#");

                for (int i = 0; i < n / 2 - row - 1; i++)
                {
                    output.Append(".");
                }

                output.Append("\n");
            }

            //#......#
            //.#....#.
            for (int row = 0; row < n / 4; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    output.Append(".");
                }

                output.Append("#");

                for (int i = 0; i < n - 2 * row - 2; i++)
                {
                    output.Append(".");
                }

                output.Append("#");

                for (int i = 0; i < row; i++)
                {
                    output.Append(".");
                }

                output.Append("\n");
            }



            //--------
            for (int row = 0; row < n; row++)
            {
                output.Append("-");
            }

            output.Append("\n");

            //\\\\////
            //.\\\///.
            //..\\//..
            //...\/...
            for (int row = 0; row < n / 2; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    output.Append(".");
                }

                for (int i = 0; i < n / 2 - row; i++)
                {
                    output.Append("\\");
                }

                for (int i = 0; i < n / 2 - row; i++)
                {
                    output.Append("/");
                }

                for (int i = 0; i < row; i++)
                {
                    output.Append(".");
                }

                output.Append("\n");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
