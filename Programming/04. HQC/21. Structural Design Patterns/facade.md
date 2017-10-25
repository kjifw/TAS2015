# Facade
## Structural Design Pattern

#### Информация и Цел
Facade е шаблон за дизайн, използван често в обектно ориентираното програмиране. Facade представлява обект, който дефинира интерфейс на високо ниво за голяма част от код, с цел по-лесно и опростено използване, например class library. Може да се каже, че Facade обвива сложна подсистема в опростен интерфейс.

#### Структура
###### Facade
Facade скрива дадения код от останалата част от приложението.

###### Subsystem
Подсистеми, предоставящи определени ресурси и услуги, изпозлвани през Facade.

###### Client
Обект използващ Facade за достъп до различните ресурси.

![Facade Image][Facade-Image-Link]

#### Демо

##### Library
~~~c#
namespace FacadePattern
{
    using System;
    using System.Collections.Generic;

    class Library
    { 
        private readonly ICollection<Book> availableBooks;

        public Library()
        {
            this.availableBooks = new List<Book>();
        }

        public void PopulateLibrary()
        {
            // populate library with books from database
        }

        public Book Find(string title)
        {
            // find book by title and return it
        }

        public ICollection<Book> GetAvailableBook()
        {
            return this.availableBooks;
        }
    }
}
~~~

##### Book
~~~c#
namespace FacadePattern
{
    using System;
    using System.Collections.Generic;

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Metadata { get; set; }

        public string Content { get; set; }

        public List<int> Bookmarks { get; set; }
    }
}
~~~

##### Book Controller
~~~c#
namespace FacadePattern
{
    using System;

    static class BookController
    {
        public static void LoadMetadata(Book book)
        {
            // loads metadata about the current book
        }

        public static void OpenBook(Book book)
        {
            // opens book in new window
        }

        public static void GoToLastBookmark(Book book)
        {
            // goes to bookmark
        }
    }
}
~~~

##### Room Controller
~~~c#
namespace FacadePattern
{
    using System;

    public class RoomController
    {
        public void AdjustLighting()
        {
            Console.WriteLine("Adjusting lighting for best experience ...");
        }
    }
}
~~~

##### Monitor Controller
~~~c#
namespace FacadePattern
{
    using System;

    public class MonitorController
    {
        public void AdjustBrightness()
        {
            Console.WriteLine("Adjusting monitor brightness for best experience ...");
        }

        public void AdjustContrast()
        {
            Console.WriteLine("Adjusting monitor contrast for best experience ...");
        }
    }
}
~~~

##### Facade
~~~c#
namespace FacadePattern
{
    using System;

    /// <summary>
    /// The Facade
    /// </summary>
    public class Facade
    {
        private Library lib;

        public Facade()
        {
            lib = new Library();
            lib.PopulateLibrary();
        }

        public void ReadBook(string title)
        {
            Book book = lib.Find(title);

            RoomController roomControl = new RoomController();
            roomControl.AdjustLighting();

            MonitorController monitorControl = new MonitorController();
            monitorControl.AdjustBrightness();
            monitorControl.AdjustContrast();

            BookController.LoadMetadata(book);
            BookController.OpenBook(book);
            BookController.GoToLastBookmark(book);
        }
    }
}
~~~

##### Usage
~~~c#
namespace FacadePattern
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var facade = new Facade();
            var title = Console.ReadLine();

            facade.ReadBook(title);
        }
    }
}
~~~

[Facade-Image-Link]: images/facade.png