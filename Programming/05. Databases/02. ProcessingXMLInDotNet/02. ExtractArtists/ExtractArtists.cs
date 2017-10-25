namespace _02.ExtractArtists
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ExtractArtists
    {
        public static void Main(string[] args)
        {
            string filePath = "../../catalogue.xml";
            Dictionary<string, int> artists = new Dictionary<string, int>();
            XmlDocument doc = new XmlDocument();

            doc.Load(filePath);

            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                string artistName = node["artist"].InnerText;

                if (artists.ContainsKey(artistName))
                {
                    artists[artistName] += 1;
                }
                else
                {
                    artists[artistName] = 1;
                }
            }

            PrintArtists(artists);
        }

        public static void PrintArtists(Dictionary<string, int> artists)
        {
            foreach (var artist in artists)
            {
                Console.WriteLine("Artist: {0}", artist.Key);
                Console.WriteLine("Number of Albums: {0}", artist.Value);
                Console.WriteLine();
            }
        }
    }
}
