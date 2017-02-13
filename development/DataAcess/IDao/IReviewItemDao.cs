using DataAcess.Dto;

namespace DataAcess.IDao
{
    public interface IReviewItemDao
    {
        void Save(ReviewItemDto dto);
        void Delete(ReviewItemDto dto);
        void GetById(long id);
        void GetByName(string name);
    }
}