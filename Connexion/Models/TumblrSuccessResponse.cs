using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Connexion.Models
{
    [DataContract]
    public class TumblrSuccessResponse
    {
        [DataMember(Name = "blog")]
        public TumblrBlogDetails blog { get; set; }
        [DataMember(Name = "posts")]
        public TumblrPosts[] posts { get; set; }
        [DataMember(Name = "total_posts")]
        public String totalPosts { get; set; }
    }

    [DataContract]
    public class TumblrBlogDetails
    {
        [DataMember(Name = "title")]
        public String title { get; set; }
        [DataMember(Name = "posts")]
        public String posts { get; set; }
        [DataMember(Name = "name")]
        public String name {get;set;}
        [DataMember(Name = "url")]
        public String url { get; set; }
        [DataMember(Name = "updated")]
        public String updated { get; set; }
        [DataMember(Name = "description")]
        public String description { get; set; }
        [DataMember(Name = "ask")]
        public String ask { get; set; }
        [DataMember(Name = "likes")]
        public String likes { get; set; }
    }
}