namespace _05.ExtractSongs
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ExtractSongs
    {
        public static void Main(string[] args)
        {
            string filePath = "../../catalogue.xml";
            XmlReader reader = XmlReader.Create(filePath);

            using (reader)
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine("Song title: {0}", reader.ReadElementContentAsString());
                    }
                }
            }
        }
    }
}
