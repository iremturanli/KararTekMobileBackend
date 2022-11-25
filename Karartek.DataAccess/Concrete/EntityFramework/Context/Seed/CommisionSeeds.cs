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
        internal static readonly List<Commision> commisions = new List<Commision>()
        {
            new Commision(){ Id=0,Name="1. Ceza Dairesi"},
            new Commision(){ Id=1,Name="10. Ceza Dairesi"},
            new Commision(){ Id=2,Name="8. Hukuk Dairesi"},
            new Commision(){ Id=3,Name="9. Ceza Dairesi"},
        };
    }
}
