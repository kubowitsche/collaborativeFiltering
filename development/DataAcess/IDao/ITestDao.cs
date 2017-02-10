using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Dto;

namespace DataAcess.IDao
{
    public interface ITestDao{
        void Save(TestDto testDto);
        void Delete(TestDto testDto);
    }
}
