using System;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfSearchTypeDal:ISearchTypeDal
    {
        public bool AddSearchType(SearchType searchType)
        {
            using var context = new AppDbContext();
            context.SearchTypes.Add(searchType);
            var result = context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteSearchType(SearchType searchType)
        {
            using var context = new AppDbContext();
            context.SearchTypes.Remove(searchType);
            var result = context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<SearchType> GetSearchTypes()
        {
            using var context = new AppDbContext();
            return context.SearchTypes.ToList();
        }

        public SearchType GetSearchTypeById(int id)
        {
            using var context = new AppDbContext();
            var searchType = context.SearchTypes.SingleOrDefault(x => x.TypeId == id);
            return searchType;
        }

        public bool UpdateSearchType(SearchType searchType)
        {
            using var context = new AppDbContext();
            context.SearchTypes.Update(searchType);
            var result = context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}

