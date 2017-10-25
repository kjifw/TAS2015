namespace _12.ExtractPricesOfAlbumsLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class ExtractPricesOfAlbumsLINQ
    {
        public static void Main(string[] args)
        {
            string filePath = "../../catalogue.xml";
            DateTime currentDate = DateTime.Now;         
            int numberOfYears = 10;
           
            XDocument doc = XDocument.Load(filePath);

            var prices = from item in doc.Descendants("album")
                         where Convert.ToInt32(item.Element("year").Value) < (currentDate.Year - numberOfYears)
                         select item.Element("price").Value;

            foreach (var price in prices)
            {
                Console.WriteLine("Album price: {0}", price);
            }
        }
    }
}
