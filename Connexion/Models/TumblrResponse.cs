using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Connexion.Models
{
    [DataContract]
    public class TumblrResponse
    {
        [DataMember(Name = "meta")]
        public TumblrMetaData meta { get; set; }
        [DataMember(Name = "response")]
        public TumblrSuccessResponse jsonResponse { get; set; }
    }
    [DataContract]
    public class TumblrMetaData
    {
        [DataMember(Name = "status")]
        public String status { get; set; }
        [DataMember(Name = "msg")]
        public String msg { get; set; }
    }
}