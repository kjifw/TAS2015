namespace _12.StackStructure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        private const int DefaultStackSize = 4;
        private int stackSize;
        private T[] array;
        private int count;

        public Stack(int stackSize = DefaultStackSize)
        {
            this.stackSize = stackSize;
            this.array = new T[stackSize];
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Push(T item)
        {
            this.count++;

            if (this.count == this.stackSize)
            {
                this.AutoGrow();
            }

            this.array[this.count] = item;
        }

        public T Pop()
        {
            this.count--;
            return this.array[this.count + 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.count; i++)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void AutoGrow()
        {
            var tempArray = new T[this.stackSize * 2];

            Array.Copy(this.array, tempArray, this.array.Length);

            this.array = tempArray;
            this.stackSize = this.array.Length;
        }
    }
}
