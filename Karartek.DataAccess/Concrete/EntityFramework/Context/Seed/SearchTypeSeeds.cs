using System;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Concrete.EntityFramework.Context.Seed
{
    public class SearchTypeSeeds
    {
        internal static readonly List<SearchType> searchTypes = new List<SearchType>()
        {
            new SearchType()
            {   Id=1,
                TypeId=1,
                TypeName="Avukatın Eklediği Kararlar",
                CreateDate=DateTime.Now,


            },
              new SearchType()
            {   Id=2,
                TypeId=2,
                TypeName="Yüksek Yargı Kararları",
                CreateDate=DateTime.Now,


            },

           
              





        };
    }
}

