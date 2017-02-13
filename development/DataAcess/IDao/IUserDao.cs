using System.Collections.Generic;
using DataAcess.Dto;

namespace DataAcess.IDao
{
    public interface IUserDao
    {
        void Save(UserDto dto);
        List<UserDto> GetAllUsers();
    }
}