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
    }
}
