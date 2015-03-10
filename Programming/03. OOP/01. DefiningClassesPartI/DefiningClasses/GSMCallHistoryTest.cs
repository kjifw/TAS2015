
namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSMCallHistoryTest
    {
        public static void Test()
        {
            const decimal pricePerMinute = 0.37m; 
            GSM myGsm = new GSM("Sony", "Experia e4");
            
            myGsm.AddCallToHistory(
                new Call(
                    new DateTime(2015, 2, 16, 21, 22, 3), 
                    "+3592 1111111111", 
                    new TimeSpan(0, 12, 45)));
            myGsm.AddCallToHistory(
                new Call(
                    new DateTime(2015, 2, 17, 20, 22, 3),
                    "+3592 2222222222",
                    new TimeSpan(0, 10, 32))); 
            myGsm.AddCallToHistory(
                 new Call(
                     new DateTime(2015, 2, 19, 17, 29, 35),
                     "+3592 1111111111",
                     new TimeSpan(0, 7, 3)));
            myGsm.AddCallToHistory(
                new Call(
                    new DateTime(2015, 3, 1, 0, 48, 53),
                    "+3592 3333333333",
                    new TimeSpan(0, 17, 38)));

            Console.WriteLine(myGsm.ToString());

            PrintCallHistory(myGsm);

            Console.WriteLine();

            decimal priceOfCallHistory = myGsm.PriceOfCallHistory(pricePerMinute);
            Console.WriteLine("total price: {0:F4}", priceOfCallHistory);
            Console.WriteLine();

            Call callToDelete = new Call(
                new DateTime(),
                "+3592 1111111111",
                new TimeSpan());

            Console.WriteLine("deleting last call by number: {0}", callToDelete.DialedNumber);

            myGsm.DeleteCallByNumber(callToDelete);
            PrintCallHistory(myGsm);
            
            Console.WriteLine();
            Console.WriteLine("deleting longest call");
            myGsm.DeleteLongesCall();
            PrintCallHistory(myGsm);

            priceOfCallHistory = myGsm.PriceOfCallHistory(pricePerMinute);
            Console.WriteLine("total price: {0:F4}", priceOfCallHistory);
            Console.WriteLine();

            Console.WriteLine("clearing all history");

            myGsm.ClearCallHistory();
            PrintCallHistory(myGsm);

            Console.WriteLine("history cleared");
        }

        public static void PrintCallHistory(GSM myGsm)
        {
            foreach (var item in myGsm.CallHistory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
