using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Dao;
using DataAcess.Dto;

namespace DataAcess.IDao
{
    public interface IReviewDao
    {
        void Save(ReviewDto reviewDto);
        void Delete(ReviewDto reviewDto);
        void Update(long user_id, long item_id);
    }
}
