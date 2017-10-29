using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Facebook.Graph.Models
{
    public class Page
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("about")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
        public string Address { get; set; }

        [JsonProperty("picture")]
        public ProfilePicture Picture { get; set; }


        public class ProfilePicture
        {
            [JsonProperty("data")]
            public PictureData Data { get; set; }
        }

        public class PictureData
        {
            [JsonProperty("height")]
            public int Height { get; set; }

            [JsonProperty("is_silhouette")]
            public bool IsSilhouette { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("width")]
            public int Width { get; set; }
        }
    }
}
