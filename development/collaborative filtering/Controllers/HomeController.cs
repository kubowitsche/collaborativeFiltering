using DataAcess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAcess.Dto;

namespace collaborative_filtering.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var _testDao = new TestDao();
            var _testDto = new TestDto
            {
                id = 0,
                text = "This is a test"
            };

            _testDao.Save(_testDto);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}