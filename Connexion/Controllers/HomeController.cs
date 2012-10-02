using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Connexion.Models;
using System.Runtime.Serialization.Json;

namespace Connexion.Controllers
{
    public class HomeController : Controller
    {
        public TumblrPosts post;
        public TumblrPosts[] postCollection;
        public HomeController()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.tumblr.com/v2/blog/mrkjffrsn.tumblr.com/posts/text?api_key=JdMtfILFiB2pqcf3xRqlSzg7WYKCT4UgcAuBctmu91g6BN91v2");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                }
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TumblrResponse));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                TumblrResponse tumblrResponse = (TumblrResponse)objResponse;
                TumblrSuccessResponse successResponse = tumblrResponse.jsonResponse;
                postCollection = successResponse.posts;
            }
            catch (Exception)
            {

            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            post = postCollection[4];  // 3
            ViewBag.bodyTitle = post.title;
            ViewBag.bodyContents = post.body;
            return View();
        }

        public ActionResult Connect()
        {
            post = postCollection[3];  // 2
            ViewBag.bodyTitle = post.title;
            ViewBag.bodyContents = post.body;
            return View();
        }

        public ActionResult Partners()
        {
            post = postCollection[2]; // 1
            ViewBag.bodyTitle = post.title;
            ViewBag.bodyContents = post.body;
            return View();
        }

        public ActionResult Contact()
        {
            post = postCollection[1];  // 0
            ViewBag.bodyTitle = post.title;
            ViewBag.bodyContents = post.body;
            return View();
        }

        public ActionResult New()
        {
            post = postCollection[5];  // 4
            ViewBag.bodyTitle = post.title;
            ViewBag.bodyContents = post.body;
            return View();
        }

        public ActionResult MomsArise()
        {
            post = postCollection[0];
            ViewBag.bodyTitle = post.title;
            ViewBag.bodyContents = post.body;
            return View();
        }
    }
}
