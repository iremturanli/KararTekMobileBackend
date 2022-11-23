using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.Extensions.Configuration;


namespace Karartek.Business.Concrete
{
    public class JudgmentPoolService:IJudgmentPoolService

    {
        List<Judgment>judgmentsList = new List<Judgment>();
        private readonly IJudgmentDal _judgmentDal;
        private readonly ILawyerJudgmentDal _lawyerJudgmentDal;
        private readonly IJudgmentPoolDal _judgmentPoolDal;
    


        public JudgmentPoolService(IJudgmentDal judgmentDal, ILawyerJudgmentDal lawyerJudgmentDal,IJudgmentPoolDal judgmentPoolDal, IConfiguration configuration)
        {
            _judgmentPoolDal = judgmentPoolDal;
            _judgmentDal = judgmentDal;
            _lawyerJudgmentDal = lawyerJudgmentDal;

        }

        public ResponseDto AddtoJudgmentPool(JudgmentPoolDto judgmentPoolDto, int judgmentId)
        {
            ResponseDto response = new ResponseDto();
            var favJudgment = _judgmentDal.Get(p => p.Id ==judgmentId);

            var judgmentPool = new JudgmentPool()
            {
                JudgmentId = favJudgment.Id,
                UserId=judgmentPoolDto.UserId,
                CreateDate=DateTime.Now,
    
                

            };


            var result = _judgmentPoolDal.Insert(judgmentPool);

            response.HasError = false;
            response.Message = "Karar Havuzune Eklendi";
            return response;

         

        }


        public ResponseDto AddLawyerJudgmenttoJudgmentPool(JudgmentPoolDto judgmentPoolDto, int judgmentId)
        {
            ResponseDto response = new ResponseDto();
            var favJudgment = _lawyerJudgmentDal.Get(p => p.Id == judgmentId);

            var judgmentPool = new JudgmentPool()
            {
               
                UserId = judgmentPoolDto.UserId,
                CreateDate = DateTime.Now,
                JudgmentId=0

            };


            var result = _judgmentPoolDal.Insert(judgmentPool);

            response.HasError = false;
            response.Message = "Karar Havuzune Eklendi";
            return response;



        }



        public bool DeleteFromJudgmentPool(int id )
        {
                var result = _judgmentPoolDal.Get(p => p.Id == id);
                _judgmentPoolDal.Delete(result);
                return true;
            
        }


        public List<Judgment> GetAll(JudgmentPoolDto judgmentPoolDto)
        {
        
            var list= new List<JudgmentPool>(_judgmentPoolDal.GetAll(p=>p.UserId==judgmentPoolDto.UserId));
 
  

            for (var i=0;i<list.Count;i++)
            {
               var temp=(list[i].JudgmentId);
    
                
                    var result = _judgmentDal.Get(p => p.Id == temp);
                    judgmentsList.Add(result);



                
              






            }
            return judgmentsList;
          



        }




    }
}
