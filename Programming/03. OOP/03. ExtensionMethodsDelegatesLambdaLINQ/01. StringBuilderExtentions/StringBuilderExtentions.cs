
namespace _01.StringBuilderExtentions
{
    using System;
    using System.Text;

    public static class StringBuilderExtentions
    {
        public static StringBuilder SubStringBuilder(this StringBuilder text, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            if (index < 0 || index > text.Length)
            {
                throw new IndexOutOfRangeException(
                    string.Format(
                    "Index should refer to a location within the string"));
            }

            if (length < 0 || length > text.Length)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format(
                    "Length should refer to a location within the string"));
            }

            if (index + length > text.Length)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format(
                    "Index and length should refer to a location within the string"));
            }

            for (int i = index; i < index + length; i++)
            {
                result.Append(text[i]);
            }

            return result;
        }
    }
}
