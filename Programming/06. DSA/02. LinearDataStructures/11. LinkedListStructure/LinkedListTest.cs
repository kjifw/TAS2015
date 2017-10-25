namespace _11.LinkedListStructure
{
    using System;

    public class LinkedListTest
    {
        public static void Main()
        {
            var list = new LinkedList<int>();
            var firstElement = new ListItem<int>(1);

            list.FirstElement = firstElement;
            firstElement.NextItem = new ListItem<int>(2);
            firstElement.NextItem.NextItem = new ListItem<int>(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
