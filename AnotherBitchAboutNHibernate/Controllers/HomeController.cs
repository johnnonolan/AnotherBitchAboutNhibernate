using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyServiceLayer;

namespace AnotherBitchAboutNHibernate.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var service = new MyService();
            var model = service.GetMyEntity();
            return View(model);
        }

    }
}
