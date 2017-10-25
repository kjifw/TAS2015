# Adapter
## Structural Design Pattern

#### Информация и Цел 
Adapter е шаблон за дизайн, който позволява интерфейсът на съществуващ клас да бъде използван през различен интерфейс.  Adapter позволява на класове, които са несъвместими помежду си, да работят заедно и да си комуникират, като обвива съществуващия клас в нов интерфейс и свързва старите компоненти към новата система. Това се прави с цел да не се променя кода на съществуващия компонент и в същото време да бъде използвана неговата функционалност.

#### Структура
###### New Application
Ново приложение, което изисква определен интерфейс за работа.

###### Wrapper
Adapter, който обвива съществуващия клас в нов интерфейс и може да работи както с новото приложение, така и със стария компонент.

###### Legacy Component
Съществуващ клас, чиято функционалност трябва да бъде изпозлвана.

![Adapter Image][Adapter-Image-Link]

#### Демо
~~~c#
namespace AdapterDesignPattern
{
    using System;
    using System.Collections.Generic;

    interface ITarget
    {
        List<string> GetProducts();
    }

    public class GameVendorAdaptee
    {
        public List<string> GetListOfGames()
        {
            List<string> games = new List<string>();

            games.Add("Game 1");
            games.Add("Game 2");
            games.Add("Game 3");
            games.Add("Game 4");

            return games;
        }
    }

    class GameVendorAdapter : ITarget
    {
        public List<string> GetProducts()
        {
            GameVendorAdaptee adaptee = new GameVendorAdaptee();
            List<string> gamesList = new List<string>();

            gamesList.AddRange(adaptee.GetListOfGames());

            return gamesList;
        }
    }


    class ShoppingPortalClient
    {
        static void Main(string[] args)
        {
            ITarget adapter = new GameVendorAdapter();
            List<string> products = adapter.GetProducts();

            foreach (string product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
        }
    }
}
~~~

[Adapter-Image-Link]: images/adapter.png