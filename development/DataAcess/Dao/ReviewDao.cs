using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Dto;
using DataAcess.IDao;
using DataAcess.Mongo;
using MongoDB.Driver.Builders;

namespace DataAcess.Dao
{
    class ReviewDao : MongoBase<ReviewDto>, IReviewDao
    {
        public ReviewDao() : base("ThisIsADatabase.Review")
        {
        }

        public void Save(ReviewDto reviewDto)
        {
            GetCollection().Save(reviewDto);
        }
       
    }
}
