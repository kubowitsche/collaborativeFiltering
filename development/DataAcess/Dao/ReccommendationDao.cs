using System.Collections.Generic;
using System.Linq;
using DataAcess.Dto;
using DataAcess.IDao;
using DataAcess.Mongo;
using MongoDB.Driver.Builders;

namespace DataAcess.Dao
{
    public class ReccommendationDao : MongoBase<ReccommendationDto>, IReccommendationDao
    {
        public ReccommendationDao() : base("ThisIsADatabase.Reccommendation")
        {
        }

        public void Save(ReccommendationDto dto)
        {
            GetCollection().Save(dto);
        }

        

        public List<ReccommendationDto> GetByUserId(long user_id)
        {
            return GetCollection().Find(Query.EQ("user_id", user_id)).ToList();
        }
    }
}