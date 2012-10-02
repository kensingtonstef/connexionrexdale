using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Connexion.Models
{
    [DataContract]
    public class TumblrPosts
    {
        [DataMember(Name = "blog_name")]
        public String blogName { get; set; }
        [DataMember(Name = "id")]
        public String id { get; set; }
        [DataMember(Name = "post_url")]
        public String postUrl { get; set; }
        [DataMember(Name = "slug")]
        public String slug { get; set; }
        [DataMember(Name = "type")]
        public String type { get; set; }
        [DataMember(Name = "date")]
        public String date { get; set; }
        [DataMember(Name = "timestamp")]
        public String timeStamp { get; set; }
        [DataMember(Name = "state")]
        public String state { get; set; }
        [DataMember(Name = "format")]
        public String format { get; set; }
        [DataMember(Name = "reblog_key")]
        public String reblog_key { get; set; }
        [DataMember(Name = "tags")]
        public String tags { get; set; }
        [DataMember(Name = "highlighted")]
        public String highlighted { get; set; }
        [DataMember(Name = "title")]
        public String title { get; set; }
        [DataMember(Name = "body")]
        public String body { get; set; }
    }
}