using DataAcess.Dto;
using DataAcess.IDao;
using DataAcess.Mongo;

namespace DataAcess.Dao
{
    public class ReccommendationgDao : MongoBase<ReccommendationDto>, IReccommendationDao
    {
        public ReccommendationgDao(string collectionName) : base(collectionName)
        {
        }

        public void Save(ReccommendationDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(ReccommendationDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}