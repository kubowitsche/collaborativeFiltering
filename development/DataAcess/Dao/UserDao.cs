using System.Collections.Generic;
using DataAcess.Dto;
using DataAcess.IDao;
using DataAcess.Mongo;

namespace DataAcess.Dao
{
    public class UserDao : MongoBase<UserDto>, IUserDao
    {
        public void Save(UserDto dto)
        {
            throw new System.NotImplementedException();
        }

        public List<UserDto> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public UserDao(string collectionName) : base(collectionName)
        {
        }
    }
}