using System;
using Core.Utilities.Results;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface ICourtService
    {
        Court GetCourtById(int id);
        IDataResult<List<CourtResponseListDto>> GetAllbyId(int id);
        IDataResult<List<CourtResponseListDto>> GetAllCourts();
    }
}

