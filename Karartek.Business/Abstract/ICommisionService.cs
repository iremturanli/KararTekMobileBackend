using System;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface ICommisionService
    {
        Commision GetCommisionById(int id);
        CommisionResponseDto GetCommision();
    }
}

