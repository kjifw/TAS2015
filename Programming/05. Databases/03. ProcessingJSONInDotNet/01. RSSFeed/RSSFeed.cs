namespace _01.RSSFeed
{
    using System;
    using System.Net;
    using System.Xml;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class RSSFeed
    {
        public static void Main(string[] args)
        {
            string rssLink = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string fileName = "../../data.xml";
            string htmlName = "../../data.html";

            var webClient = new WebClient();
            webClient.DownloadFile(rssLink, fileName);

            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            string jsonStr = JsonConvert.SerializeXmlNode(doc);
            JObject jsonObj = JObject.Parse(jsonStr);

            var videos = GetVideos(jsonObj);

            var html = GenerateHTML(videos);

            WriteToHTMLFile(html, htmlName);

            Console.WriteLine("Rss feed download and saved to data.html");
        }

        public static IEnumerable<Video> GetVideos(JObject jsonObj)
        {
            IEnumerable<Video> videos = new List<Video>();

            videos = jsonObj["feed"]["entry"].Select(x => JsonConvert.DeserializeObject<Video>(x.ToString()));

            return videos;
        }

        public static string GenerateHTML(IEnumerable<Video> videos)
        {
            StringBuilder htmlCode = new StringBuilder();
            
            htmlCode.AppendLine("<!DOCTYPE html>");
            htmlCode.AppendLine("<html>");

            htmlCode.AppendLine("<head>");
            htmlCode.AppendLine("<meta charset=\"UTF-8\" />");
            htmlCode.AppendLine("<style>");
            htmlCode.AppendLine("h4 { display: inline-block; }");
            htmlCode.AppendLine("div { width: 500px; }");            
            htmlCode.AppendLine("}");
            htmlCode.AppendLine("</style>");
            htmlCode.AppendLine("</head>");

            htmlCode.AppendLine("<body>");

            foreach (var item in videos)
            {
                htmlCode.AppendFormat(
                    @"<div>
                    <h4>{0}</h4>                    
                    <a href=""{1}"" target=""blank"">YouTube Link</a>
                    <br />
                    <iframe width=""420"" height=""315"" src=""https://www.youtube.com/embed/{2}"" frameborder=""0"" allowfullscreen></iframe>
                    </div>",
                    item.Title, item.Link, item.Id);
            }

            htmlCode.AppendLine("</body>");

            htmlCode.AppendLine("</html>");

            return htmlCode.ToString();
        }

        public static void WriteToHTMLFile(string html, string htmlName)
        {
            StreamWriter writer = new StreamWriter(htmlName);

            using(writer)
            {
                writer.Write(html);
            }
        }
    }
}
