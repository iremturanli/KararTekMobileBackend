using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Concrete.EntityFramework.Context.Seed
{
    internal static class JudgmentTypeSeeds
    {
        internal static readonly List<JudgmentType> judgmentTypes = new List<JudgmentType>()
        {
            new JudgmentType()
            {
                 Id=1,
                 TypeId=1,
                 TypeName="Yargıtay",
                 CreateDate=DateTime.Now
            },
             new JudgmentType()
            {    Id=2,
                 TypeId=2,
                 TypeName="Danıştay",
                 CreateDate=DateTime.Now

            },
               new JudgmentType()
            {    Id=3,
                 TypeId=3,
                 TypeName="Anayasa Mahkemesi",
                 CreateDate=DateTime.Now

            }



        };

    }
}