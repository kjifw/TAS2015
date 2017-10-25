namespace _01.RSSFeed
{
    using System;
    using Newtonsoft.Json;

    public class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("yt:videoId")]
        public string Id { get; set; }

        public override string ToString()
        {
            return "ENTRY: \n" + this.Title + "\n" + this.Link + "\n" + this.Id + "\n";
        }
    }
}
