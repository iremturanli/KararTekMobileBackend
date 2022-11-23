using System;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Concrete
{
    public class SearchTypeService : ISearchTypeService
    {
        private ISearchTypeDal _searchTypeDal;
        public SearchTypeService(ISearchTypeDal searchTypeDal)
        {
            _searchTypeDal = searchTypeDal;
        }


        public bool AddSearchType(SearchType searchType)
        {
            var searchTypeEntity = new SearchType
            {
                TypeName = searchType.TypeName,
                CreateDate = DateTime.Now,
                TypeId = searchType.TypeId,

            };
            return _searchTypeDal.AddSearchType(searchTypeEntity);
        }

        public bool DeleteSearchType(SearchType searchType)
        {
            return _searchTypeDal.DeleteSearchType(searchType);
        }


        public SearchType GetSearchTypeById(int id)
        {
            return _searchTypeDal.GetSearchTypeById(id);
        }
        public SearchTypeResponseDto GetSearchTypes()
        {
            var result = new SearchTypeResponseDto
            {
                SearchTypes = _searchTypeDal.GetSearchTypes(),
                HasError = false,
                Message = "Success"
            };
            return result;
        }

        public bool UpdateSearchType(SearchType searchType)
        {
            return _searchTypeDal.UpdateSearchType(searchType);
        }

   
    }
}

