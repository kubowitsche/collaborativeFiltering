using DataAcess.Dto;
using DataAcess.IDao;
using DataAcess.Mongo;

namespace DataAcess.Dao
{
    public class ReviewItemDao : MongoBase<ReviewItemDto>, IReviewItemDao
    {
        public ReviewItemDao(string collectionName) : base(collectionName)
        {
        }

        public void Save(ReviewItemDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(ReviewItemDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}