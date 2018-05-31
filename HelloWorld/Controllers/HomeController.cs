using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from AWS CodeCommit, CodeBuild, CodeDeploy and CodePipleline. Congrats on getting this to work.";
            return View();
        }
    }
}