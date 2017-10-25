namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public static class BinarySearchAlgorithm
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array cannot be null.");
            Debug.Assert(value != null, "Value cannot be null.");
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, string.Format("Start index: {0} is out of range.", startIndex));
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, string.Format("End index: {0} is out of range.", endIndex));

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
