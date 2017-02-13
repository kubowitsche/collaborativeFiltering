using System.Collections.Generic;
using System.Linq;
using DataAcess.Dto;
using DataAcess.IDao;
using DataAcess.Mongo;

namespace DataAcess.Dao
{
    public class UserDao : MongoBase<UserDto>, IUserDao
    {
        public UserDao() : base("ThisIsADatabase.Users")
        {
        }
        public void Save(UserDto dto)
        {
            GetCollection().Save(dto);
        }

        public List<UserDto> GetAllUsers()
        {
            return GetCollection().FindAll().ToList();
        }

       
    }
}