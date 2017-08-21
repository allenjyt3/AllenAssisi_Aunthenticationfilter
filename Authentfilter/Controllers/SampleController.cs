using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authentfilter.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        [OutputCache(Duration =10)]
        public ActionResult Index1()
        {
            return View();
        }
    }
}