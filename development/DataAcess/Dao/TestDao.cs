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
    public class TestDao : MongoBase<TestDto>, ITestDao
    {
        public TestDao() : base("Test")
        {
        }

        public void Save(TestDto testDto)
        {
            GetCollection().Save(testDto);
        }

        public void Delete(TestDto testDto)
        {
            GetCollection().Remove(Query.EQ("_id", testDto.id));
        }

        
    }
}
