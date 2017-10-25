namespace _06.ExtractSongsLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class ExtractSongsLINQ
    {
        public static void Main(string[] args)
        {
            string filePath = "../../catalogue.xml";
            XDocument doc = XDocument.Load(filePath);

            var songs = from item in doc.Descendants("title")
                        select item.Value;

            foreach (var song in songs)
            {
                Console.WriteLine("Song title: {0}", song);
            }
        }
    }
}
