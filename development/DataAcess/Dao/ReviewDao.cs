using System;
using DataAcess.Dto;
using DataAcess.IDao;
using DataAcess.Mongo;

namespace DataAcess.Dao
{
    public class ReviewDao : MongoBase<ReviewDto>, IReviewDao
    {
        public ReviewDao() : base("Review")
        {
        }

        public void Save(ReviewDto reviewDto)
        {
            GetCollection().Save(reviewDto);
        }

        public void Update(long user_id, long item_id)
        {
            throw new NotImplementedException();
        }
    }
}
