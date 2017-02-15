using System;
using System.Web;

namespace collaborative_filtering.Models
{
    public class ReviewItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Recommendation recommendation { get; set; }
    }
    public class Recommendation
    {
        public float EstimatedRating { get; set; }
    }
    public class CreateReview {
        public int rating { get; set; }
        public string text { get; set; }
    }
}
