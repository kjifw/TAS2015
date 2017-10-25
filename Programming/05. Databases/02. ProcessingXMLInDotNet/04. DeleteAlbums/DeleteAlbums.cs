namespace _04.DeleteAlbums
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class DeleteAlbums
    {
        public static void Main(string[] args)
        {
            string filePath = "../../catalogue.xml";
            double borderPrice = 20.0;
            List<XmlNode> nodesToRemove = new List<XmlNode>();
            
            XmlDocument doc = new XmlDocument();

            doc.Load(filePath);

            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                string priceStr = node["price"].InnerText;
                double price = Convert.ToDouble(priceStr);

                if (price > borderPrice)
                {
                    nodesToRemove.Add(node);
                }
            }


            foreach (XmlNode node in nodesToRemove)
            {
                rootNode.RemoveChild(node);
            }

            doc.Save("../../newCatalogue.xml");
            Console.WriteLine("Updated catalog created.");
        }
    }
}
