using System;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface ISearchTypeDal
    {
        bool AddSearchType(SearchType searchType);

        bool DeleteSearchType(SearchType searchType);

        bool UpdateSearchType(SearchType searchType);

        SearchType GetSearchTypeById(int id);
        List<SearchType> GetSearchTypes();
    }
}

