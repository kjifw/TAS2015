# Proxy
## Structural Design Pattern

#### Информация и Цел
Proxy е шаблон за дизайн, който в общия случай функционира като интерфейс за достъп към даден ресурс. Това става чрез обвиване на другите обекти в обвиващ клас. Този обвиващ клас може да добавя допълнителна функционалност към дадените обекти, без да се променя техния код, като например може да бъде добавена функционалност за повишаване на сигурността, чрез контролиране на достъпа към обектите. Също така Proxy може да се използва за опростяване на API на сложни обекти.

#### Структура
###### Subject
Дефинира общ интерфейс за достъп за RealSubject и Proxy, така че Proxy да може да бъде използва навсякъде, където може да бъде използван RealSubject.

###### RealSubject
Дефинира обекта, който се представлява от Proxy.

###### Proxy
Поддържа референция, която дава достъп на Proxy обекта до RealSubject обекта. Осигурява интерфейс идентичен на RealSubject, така че да може Proxy да подмени RealSubject.

###### Client
Обект жеалещ да използва определени ресурси.

![Proxy Image][Proxy-Image-Link]

#### Демо
~~~c#
namespace BookProxy
{
    using System;

    interface IBook
    {
        void Read();
    }

    public class Book : IBook
    {
        public void Read()
        {
            Console.WriteLine("Book is being read!");
        }
    }

    public class BookProxy : IBook
    {
        private IBook book;
        private Person bookReader;

        public BookProxy(Person bookReader)
        {
            this.book = new Book();
            this.bookReader = bookReader;
        }

        public void Read()
        {
            if (this.bookReader.Age < 18)
            {
                Console.WriteLine("Cannot read book, client too young!");
            }
            else
            {
                this.book.Read();
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " Age: " + this.Age;
        }
    }

    class BookClient
    {
        static void Main()
        {
            var firstPerson = new Person("John Doe", 17);
            var proxy = new BookProxy(firstPerson);

            Console.WriteLine(firstPerson.ToString());
            proxy.Read();
            Console.WriteLine();

            var secondPerson = new Person("Jane Doe", 18);
            proxy = new BookProxy(secondPerson);

            Console.WriteLine(secondPerson.ToString());
            proxy.Read();
            Console.WriteLine();
        }
    }
}
~~~

[Proxy-Image-Link]: images/proxy.png