namespace _08.ExtractAlbumAndAuthor
{
    using System;
    using System.Xml;

    public class ExtractAlbumAndAuthor
    {
        public static void Main(string[] args)
        {
            string filePathInput = "../../catalogue.xml";
            string filePathOutput = "../../albums.xml";

            XmlReader reader = XmlReader.Create(filePathInput);
            XmlWriter writer = XmlWriter.Create(filePathOutput); 

            using (reader)
            using (writer)
            {
                writer.WriteStartElement("albums");

                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "name"))
                    {
                        writer.WriteStartElement("ablum");
                        var albumName = reader.ReadElementContentAsString();
                        writer.WriteElementString("name", albumName);
                    }

                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "artist"))
                    {
                        var artist = reader.ReadElementContentAsString();
                        writer.WriteElementString("artist", artist);
                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndElement();
            }

            Console.WriteLine("Albums and artists extracted from catalogue.xml and saved in albums.xml.");
        }
    }
}
