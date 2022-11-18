using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Concrete.EntityFramework.Context.Seed
{
    internal static class UserTypeSeeds
    {
        internal static readonly List<UserType> userTypes = new List<UserType>()
        {

            new UserType
            {
                Id=1,
                TypeId = 1,
                TypeName = "Öğrenci",
                CreateDate = DateTime.Now,

            },
            new UserType
            {   Id=2,
                TypeId = 2,
                TypeName = "Avukat - Avukat Stajyeri",
                CreateDate = DateTime.Now,
            }
        };

    }
}
