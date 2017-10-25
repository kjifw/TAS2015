namespace _11.ExtractPricesOfAlbums
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.XPath;

    public class ExtractPricesOfAlbums
    {
        public static void Main(string[] args)
        {
            string filePath = "../../catalogue.xml";
            // value modified from 5 to 10 because of the selection in catalogue
            int numberOfYears = 10;

            XPathDocument doc = new XPathDocument(filePath);
            XPathNavigator nav = doc.CreateNavigator();

            DateTime currentDate = DateTime.Now;

            string strExpression = "/catalogue/album/price[../year<" + (currentDate.Year - numberOfYears) + "]";

            XPathNodeIterator iterator = nav.Select(strExpression);

            while (iterator.MoveNext())
            {
                Console.WriteLine("Album price: {0}", iterator.Current.Value);
            }
        }
    }
}
