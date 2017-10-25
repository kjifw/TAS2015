namespace _07.TextToXml
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    public class TextToXml
    {
        public static void Main(string[] args)
        {
            string filePathText = "../../text.txt";
            string filePathXml = "../../text.xml";
            StreamReader reader = new StreamReader(filePathText);
            StreamWriter writer = new StreamWriter(filePathXml);
            
            Person firstPerson = new Person();

            using (reader)
            {
                firstPerson.Name = reader.ReadLine();
                firstPerson.Address = reader.ReadLine();
                firstPerson.PhoneNumber = reader.ReadLine();
            }

            XmlSerializer serializer = new XmlSerializer(firstPerson.GetType());

            serializer.Serialize(writer, firstPerson);
            Console.WriteLine("Person saved to xml file.");
        }
    }
}
