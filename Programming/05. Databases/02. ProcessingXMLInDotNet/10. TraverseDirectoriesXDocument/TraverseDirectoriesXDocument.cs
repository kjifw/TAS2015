namespace GetFilesAndFolders
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

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
            XDocument doc = new XDocument();
            var root = new XElement("items");

            foreach (var dir in items)
            {
                var dirElement = new XElement("dir");
                dirElement.SetAttributeValue("path", dir.Key);

                foreach (var file in dir.Value)
                {
                    var fileElement = new XElement("file");
                    fileElement.SetValue(file.Substring(file.LastIndexOf("\\") + 1));
                    dirElement.Add(fileElement);
                }

                root.Add(dirElement);
            }

            doc.Add(root);
            doc.Save(xmlFilePath);
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
