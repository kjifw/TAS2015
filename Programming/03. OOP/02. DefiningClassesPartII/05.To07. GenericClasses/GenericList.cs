
namespace _05.To07.GenericClasses
{
    using System;
    using System.Text;

    public class GenericList<T>
    {
        private const int defaultCapacity = 20;
        private T[] elements;
        private int count = 0;

        public GenericList()
            : this(defaultCapacity)
        { 

        }

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
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
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                T element = this.elements[index];
                return element;
            }
        }

        public void Add(T elementToAdd)
        {
            if (this.Count >= this.elements.Length)
            {
                T[] arr = new T[(this.elements.Length + 1) * 2];

                for (int i = 0; i < this.elements.Length; i++)
                {
                    arr[i] = this.elements[i];
                }

                this.elements = arr;
            }

            this.elements[this.Count] = elementToAdd;
            this.Count++;
        }

        public T GetElementByIndex(int index)
        {
            T element;

            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException(string.Format("You can not get element at invalid positon {0}", index));
            }

            element = this.elements[index];

            return element;
        }

        public int GetIndexByValue(T value)
        {
            int index = -1;

            for (int i = 0; i < this.Count; i++)
            {
                if (value.Equals(this.elements[i]))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(string.Format("You can not remove element at invalid positon {0}", index));
            }

            T[] arr = new T[this.Count - 1];

            if (index == this.count - 1)
            {
                for (int i = 0; i < this.Count - 1; i++)
                {
                    arr[i] = this.elements[i];
                }

                this.elements = arr;
                this.Count--;
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    arr[i] = this.elements[i];
                }

                for (int i = index + 1; i < this.Count; i++)
                {
                    arr[i - 1] = this.elements[i];
                }

                this.elements = arr;
                this.Count--;
            }
        }

        public void Insert(int index, T element)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(string.Format("You can not add element at invalid positon {0}", index));
            }

            T[] arr = new T[this.Count + 1];

            for (int i = 0; i < index; i++)
            {
                arr[i] = this.elements[i];
            }

            arr[index] = element;
            this.Count++;

            for (int i = index + 1; i < this.Count; i++)
            {
                arr[i] = this.elements[i - 1];
            }

            this.elements = arr;
        }

        public void Clear()
        {
            this.Count = 0;
            this.elements = new T[this.Count];
        }

        public T Min()
        {
            T minElement = this.elements[0];

            for (int i = 0; i < this.Count; i++)
            {
                if ((dynamic)this.elements[i] < minElement)
                {
                    minElement = this.elements[i];
                }
            }

            return minElement;
        }

        public T Max()
        {
            T maxElement = this.elements[0];

            for (int i = 0; i < this.Count; i++)
            {
                if ((dynamic)this.elements[i] > maxElement)
                {
                    maxElement = this.elements[i];
                }
            }

            return maxElement;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                if (i != this.Count - 1)
                {
                    result.AppendFormat("{0} ", this.elements[i]);
                }
                else
                {
                    result.AppendFormat("{0}", this.elements[i]);
                }
            }

            return result.ToString();
        }
    }
}
