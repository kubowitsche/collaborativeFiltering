﻿using System.Collections.Generic;
using DataAcess.Dto;

namespace DataAcess.IDao
{
    public interface IReccommendationDao
    {
        void Save(ReccommendationDto dto);
        List<ReccommendationDto> GetByUserId(long user_id);
    }
}