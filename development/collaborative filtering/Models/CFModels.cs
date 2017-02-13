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
        public string EstimatedRating { get; set; }
    }
}
