using DataAcess.Dto;

namespace DataAcess.IDao
{
    public interface IReviewItemDao
    {
        void Save(ReviewItemDto dto);
        void Delete(ReviewItemDto dto);
        ReviewItemDto GetById(long id);
        ReviewItemDto GetByName(string name);
    }
}