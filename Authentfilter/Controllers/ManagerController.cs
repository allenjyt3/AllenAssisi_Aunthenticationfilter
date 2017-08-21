using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authentfilter.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        [TestAuthentication]
        public ActionResult Index()
        {
            return View();
        }
    }
}