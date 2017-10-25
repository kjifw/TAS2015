namespace _14.ApplyXSLTStyles
{
    using System;
    using System.Xml.Xsl;

    public class ApplyXSLTStyles
    {
        public static void Main(string[] args)
        {
            string xsltPath = "../../style.xslt";
            string inputFilePath = "../../catalogue.xml";
            string outputFilePath = "../../catalogue.html";

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xsltPath);
            xslt.Transform(inputFilePath, outputFilePath);

            Console.WriteLine("Xml styles applied. Result location: {0}", 
                outputFilePath.Substring(outputFilePath.LastIndexOf("/") + 1));
        }
    }
}
