
namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray : IEnumerable<ulong>
    {
        private const int defaultCapacity = 20;

        private ulong[] numbers;
        private int count;

        public BitArray(int capacity = defaultCapacity)
        {
            this.numbers = new ulong[capacity];
            this.Count = capacity;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public ulong this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index must be within the boundries of the array");
                }

                ulong element = this.numbers[index];

                return element;
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index must be within the boundries of the array");
                }

                this.numbers[index] = value;
            }
        }

        public override bool Equals(object obj)
        {
            bool areEqual = false;
            BitArray second = obj as BitArray;
            int currentCount = 0;

            if (obj == null)
            {
                areEqual = false;
            }
            else if ((object)second == null)
            {
                areEqual = false;
            }
            else if(this.Count == second.Count)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (this[i] == second[i])
                    {
                        currentCount++;
                    }
                }

                if (this.Count == currentCount)
                {
                    areEqual = true;
                }
            }
            else
            {
                areEqual = false;
            }

            return areEqual;
        }

        public static bool operator ==(BitArray first, BitArray second)
        {
            bool areEqual = false;

            if (Object.ReferenceEquals(first, second))
            {
                areEqual = true;
            }
            else if (((object)first == null) || ((object)second == null))
            {
                areEqual = false;
            }
            else
            {
                areEqual = first.Equals(second);
            }

            return areEqual;
        }

        public static bool operator !=(BitArray first, BitArray second)
        {
            bool areDifferent = true;

            if (Object.ReferenceEquals(first, second))
            {
                areDifferent = false;
            }
            else if (((object)first == null) || ((object)second == null))
            {
                areDifferent = true;
            }
            else
            {
                areDifferent = !(first.Equals(second));
            }

            return areDifferent;
        }

        public override int GetHashCode()
        {
            int hash = 17;

            for (int i = 0; i < this.Count; i++)
            {
                hash = hash ^ this.numbers[i].GetHashCode();
            }

            return hash;
        }

        public IEnumerator<ulong> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this[i]; 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder bitArrayStrB = new StringBuilder();

            foreach (var item in this.numbers)
            {
                bitArrayStrB.Append(item + " ");
            }

            return bitArrayStrB.ToString().Trim();
        }
    }
}
