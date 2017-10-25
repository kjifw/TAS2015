namespace GetFilesAndFolders
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;

    public static class GetInfo
    {
        private static Dictionary<string, List<string>> allFilesAndFolders = new Dictionary<string, List<string>>();

        public static void Main(string[] args)
        {
            string directoryPath;
            string xmlFilePath = "../../info.xml";
            Dictionary<string, List<string>> items = new Dictionary<string, List<string>>();

            Console.WriteLine("Input directory path: ");
            directoryPath = Console.ReadLine();

            items = DirectorySearch(directoryPath);

            WriteContentToFile(xmlFilePath, items);

            Console.WriteLine("All files and folders written to info.xml");
        }

        public static void WriteContentToFile(string xmlFilePath, Dictionary<string, List<string>> items)
        {
            XmlWriter writer = XmlWriter.Create(xmlFilePath);

            using(writer)
            {
                writer.WriteStartElement("items");

                foreach (var dir in items)
                {
                    writer.WriteStartElement("dir");
                    writer.WriteAttributeString("name", dir.Key);

                    foreach (var file in dir.Value)
                    {
                        writer.WriteStartElement("file");
                        writer.WriteString(file.Substring(file.LastIndexOf("\\") + 1));
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }
        }

        public static Dictionary<string, List<string>> DirectorySearch(string currentDirectory)
        {
            string[] listOfDirectories = Directory.GetDirectories(currentDirectory);
            string[] listOffiles = Directory.GetFiles(currentDirectory);

            if (allFilesAndFolders.ContainsKey(currentDirectory))
            {
                allFilesAndFolders[currentDirectory] = listOffiles.ToList();
            }
            else
            {
                allFilesAndFolders.Add(currentDirectory, listOffiles.ToList());
            }

            foreach (string dir in listOfDirectories)
            {
                listOffiles = Directory.GetFiles(dir);

                allFilesAndFolders.Add(dir, listOffiles.ToList());

                DirectorySearch(dir);
            }

            return allFilesAndFolders;
        }
    }
}
