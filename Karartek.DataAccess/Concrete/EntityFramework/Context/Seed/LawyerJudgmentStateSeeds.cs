using System;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Concrete.EntityFramework.Context.Seed
{
    public class LawyerJudgmentStateSeeds
    {
        internal static readonly List<LawyerJudgmentState> LawyerJudgmentState = new List<LawyerJudgmentState>()
        {
            new LawyerJudgmentState()
            {   Id=1,
                StateId=1,
                StateName="Onaya Gönderildi",//state
                CreateDate=DateTime.Now,


            },
              new LawyerJudgmentState()
            {   Id=2,
                  StateId=2,
                StateName="Onay Bekliyor",
                CreateDate=DateTime.Now,


            },

               new LawyerJudgmentState()
            {   Id=3,
                  StateId=3,
                StateName="Reddedildi",
                CreateDate=DateTime.Now,


            },
               new LawyerJudgmentState()
            {   Id=4,
                  StateId=4,
                StateName="Onaylandı",
                CreateDate=DateTime.Now,


            }





        };
    }
}

