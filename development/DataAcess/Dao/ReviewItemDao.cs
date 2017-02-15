using System;
using DataAcess.Dto;
using DataAcess.IDao;
using DataAcess.Mongo;
using MongoDB.Driver.Builders;

namespace DataAcess.Dao
{
    public class ReviewItemDao : MongoBase<ReviewItemDto>, IReviewItemDao
    {
        public ReviewItemDao() : base("ReviewItem")
        {
        }

        public void Save(ReviewItemDto dto)
        {
            GetCollection().Save(dto);
        }

        public void Delete(ReviewItemDto dto)
        {
            //GetCollection().Remove(Query.EQ("_id", dto.id));
        }

        public ReviewItemDto GetById(long review_item_id)
        {
            return GetCollection().FindOne(Query.EQ("review_item_id", review_item_id));
        }

        public ReviewItemDto GetByName(string name)
        {
            return GetCollection().FindOne(Query.EQ("name", name));
        }
    }
}