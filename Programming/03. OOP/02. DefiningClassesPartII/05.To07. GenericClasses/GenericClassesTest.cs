
namespace _05.To07.GenericClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class GenericClassesTest
    {
        static void Main(string[] args)
        {
            // for tasks conditions refer to Tasks.txt in the current project
            GenericList<int> someList = new GenericList<int>(4);
            someList.Add(2);
            someList.Add(-15);
            someList.Add(123);
            someList.Add(-887);
            someList.Add(667);
            Console.WriteLine(someList);

            Console.WriteLine("remove element at index 3: ");
            someList.RemoveAt(3);
            Console.WriteLine(someList);
            
            Console.WriteLine("element at index 2: ");
            Console.WriteLine(someList[2]);

            Console.WriteLine("clear list");
            someList.Clear();
            Console.WriteLine(someList);

            Console.WriteLine("add new elements");
            someList.Add(-847);
            someList.Add(667);
            someList.Add(-121);
            someList.Add(359);
            Console.WriteLine(someList);

            Console.WriteLine("insert number 19597 at index 1");
            someList.Insert(1, 19597);

            Console.WriteLine(someList);

            Console.WriteLine("find index of element by value -121");
            int index = someList.GetIndexByValue(-121);
            Console.WriteLine(index);

            Console.WriteLine("min element: ");
            Console.WriteLine(someList.Min());
            Console.WriteLine("max element: ");
            Console.WriteLine(someList.Max());
        }
    }
}
