using MongoDB.Driver;

namespace DataAcess.Mongo
{
    public static class Database
    {
        private static readonly string _mongoDbConnection = "mongodb://localhost:27017/connectTimeoutMS=30000";
        private static readonly string _mongoDatabaseName = "ThisIsADatabase";

        private static MongoClient _mongoClient;
        private static MongoDatabase _mongoDatabase;

        public static MongoDatabase MongoDatabase
        {
            get
            {
                if (_mongoClient == null || _mongoDatabase == null)
                {
                    _mongoClient = new MongoClient(_mongoDbConnection);

                    //TODO: Figure out how the 'new' stuff works
                    _mongoDatabase = _mongoClient.GetServer().GetDatabase(_mongoDatabaseName);
                }

                return _mongoDatabase;
            }
        }
    }

    public class MongoBase<T>
    {
        protected string Collection { get; }

        public MongoBase(string collectionName)
        {
            Collection = collectionName;
        }

        public MongoCollection<T> GetCollection()
        {
            return Database.MongoDatabase.GetCollection<T>(Collection);
        }
    }
}