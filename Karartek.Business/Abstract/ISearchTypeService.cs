using System;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface ISearchTypeService
    {
        bool AddSearchType(SearchTypeDto searchType);
        bool DeleteSearchType(SearchType searchType);
        SearchType GetSearchTypeById(int id);
        bool UpdateSearchType(SearchType searchType);
        SearchTypeResponseDto GetSearchTypes();

    }
}

