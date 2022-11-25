using System;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface ICommisionService
    {
        Commission GetCommisionById(int id);
        CommisionResponseDto GetCommision();
    }
}

