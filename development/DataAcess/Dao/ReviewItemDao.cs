using DataAcess.Dto;
using DataAcess.IDao;
using DataAcess.Mongo;
using MongoDB.Driver.Builders;

namespace DataAcess.Dao
{
    public class ReviewItemDao : MongoBase<ReviewItemDto>, IReviewItemDao
    {
        public ReviewItemDao() : base("ThisIsADatabase.ReviewItem")
        {
        }

        public void Save(ReviewItemDto dto)
        {
            GetCollection().Save(dto);
        }

        public void Delete(ReviewItemDto dto)
        {
            GetCollection().Remove(Query.EQ("_id", dto.id));
        }

        public void GetById(long id)
        {
            GetCollection().FindOne(Query.EQ("_id", id));
        }

        public void GetByName(string name)
        {
            GetCollection().Find(Query.EQ("name", name));
        }
    }
}