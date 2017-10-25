namespace CohesionAndCoupling
{
    using System;

    public static class FileUtilities
    {
        public static string GetFileExtension(string fileName)
        {
            FileUtilities.ValidateName(fileName);

            int indexOfLastDot = fileName.LastIndexOf(".");
            string extension = string.Empty;

            if (indexOfLastDot > 0)
            {
                extension = fileName.Substring(indexOfLastDot + 1);
            }

            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            FileUtilities.ValidateName(fileName);

            int indexOfLastDot = fileName.LastIndexOf(".");
            string nameWithoutExtension = fileName;

            if (indexOfLastDot > 0)
            {
                nameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            }

            return nameWithoutExtension;
        }

        private static void ValidateName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName.Trim()))
            {
                throw new ArgumentException("File name cannot be null or empty.");
            }
        }
    }
}
