using MongoDB.Bson;

namespace DataAcess.Dto
{
    public class UserDto
    {
        public ObjectId _id { get; set; }
        public long user_id { get; set; }
        public string name { get; set; }
    }
}