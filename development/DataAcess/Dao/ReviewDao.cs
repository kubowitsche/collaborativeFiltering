using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Dto;
using DataAcess.IDao;
using DataAcess.Mongo;

namespace DataAcess.Dao
{
    class ReviewDao : MongoBase<ReviewDto>, IReviewDao
    {
        public ReviewDao(string collectionName) : base(collectionName)
        {
        }

        public void Save(ReviewDto reviewDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(ReviewDto reviewDto)
        {
            throw new NotImplementedException();
        }
    }
}
