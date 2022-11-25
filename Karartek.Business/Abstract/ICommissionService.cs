using System;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface ICommissionService
    {
        Commission GetCommissionById(int id);
        CommissionResponseDto GetCommission();
    }
}

