
namespace _03.RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : Exception
    {
        private string message = "The argument is not in the predefined range of values";
        private T lowBorder;
        private T highBorder;

        public InvalidRangeException(T start, T end)
        {
            this.LowBorder = start;
            this.HighBorder = end;
        }

        public T LowBorder
        {
            get
            {
                return this.lowBorder;
            }
            private set
            {
                this.lowBorder = value;
            }
        }

        public T HighBorder
        {
            get
            {
                return this.highBorder;
            }
            private set
            {
                this.highBorder = value;
            }
        }

        public string Message
        {
            get
            {
                return this.message;
            }
        }
    }
}
