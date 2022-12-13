using Karartek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Karartek.DataAccess.Concrete.EntityFramework.Context.Seed
{
    internal static class CommisionSeeds
    {
        internal static readonly List<Commission> commissions = new List<Commission>()
        {
            new Commission(){ Id=1,Name="1. Ceza Dairesi"},
            new Commission(){ Id=2,Name="10. Ceza Dairesi"},
            new Commission(){ Id=3,Name="8. Hukuk Dairesi"},
            new Commission(){ Id=4,Name="9. Ceza Dairesi"}
        };
    }
}
