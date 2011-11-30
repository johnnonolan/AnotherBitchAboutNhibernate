using System.Web.Mvc;
using AnotherBitchAboutNHibernate.Models;
using MyServiceLayer;

namespace AnotherBitchAboutNHibernate.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            
            var models = new MyModels();
            
            return View(models.GetEm());
        }

    }
}
