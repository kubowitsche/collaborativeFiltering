using System.Web.Mvc;
using collaborative_filtering.Models;

namespace collaborative_filtering.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ViewRec()
        {
            GenerateRecommendation();
            return View(new ReviewItem());
        }

        public void GenerateRecommendation()
        {

        }
    }
}