﻿using System;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface ICourtService
    {
        Court GetCourtById(int id);
        CourtResponseDto GetCourt();
    }
}

