using HtmlAgilityPack;
using RestSharp;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using Test1.Models;
using Test1.Utils.restUtil;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        RestClientUtil restUtil = new RestClientUtil();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.newsModel = restUtil.getCompanyNews("Products", "ayalalandinc");
            //ViewBag.test = restUtil.getStringData("Products");
            return View();
        }
    }
}