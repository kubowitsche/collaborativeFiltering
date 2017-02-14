using DataAcess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAcess.Dto;
using collaborative_filtering.Models;
using DataAcess.IDao;

namespace collaborative_filtering.Controllers
{
    public class HomeController : Controller
    {
        IUserDao userDao = new UserDao();
        IReccommendationDao recDao = new ReccommendationDao();
        IReviewItemDao itemDao = new ReviewItemDao();
        IReviewDao reviewDao = new ReviewDao();


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
            ReviewItem item = GenerateRecommendation();
            return View(item);
        }

        public ReviewItem GenerateRecommendation()
        {
            //get users
            List<UserDto> users = userDao.GetAllUsers();
            UserDto user = users.First();
            //get recommendations by user id
            List<ReccommendationDto> recommendations = recDao.GetByUserId(user.user_id);
            //find top 10
            recommendations.Sort();//Figure out your comaparer
            int choosing = recommendations.Count() > 9 ? 10 : recommendations.Count()-1;
            Random rnd = new Random();
            int random = rnd.Next(0, choosing);
            long itemId = recommendations.ElementAt(random).item_id;
            ReviewItemDto revItem = itemDao.GetById(itemId);
            ReviewItem modelItem = new ReviewItem();
            modelItem.Description = revItem.description;
            modelItem.Name = revItem.name;
            modelItem.recommendation = new Recommendation();
            modelItem.recommendation.EstimatedRating = recommendations.ElementAt(random).rating;
            return modelItem;
        }

        public ActionResult AddReview(CreateReview model)
        {
            ReviewDto review = new ReviewDto();
            review.rating = model.rating;
            review.text = model.text;
            Random rnd = new Random();
            int random = rnd.Next(100000, 30000);
            int random2 = rnd.Next(30000, 50000);
            long userID = Convert.ToInt64(random2);
            long itemID = Convert.ToInt64(random);
            review.item_id = itemID;
            review.item_id = userID;

            reviewDao.Save(review);

            return View();


        }
    }
}