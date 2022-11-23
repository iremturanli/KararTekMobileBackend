using System;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Concrete
{
    public class LawyerJudgmentService : ILawyerJudgmentService
    {

        private readonly ILawyerJudgmentDal _lawyerJudgmentDal;

        public LawyerJudgmentService(ILawyerJudgmentDal lawyerJudgmentDal)
        {
            _lawyerJudgmentDal = lawyerJudgmentDal;
        }
    
            public bool AddLawyerJudgment(LawyerJudgmentDto lawyerJudgmentDto)
        {
                var judgment = _lawyerJudgmentDal.GetLawyerJudgmentByDecreeNo(lawyerJudgmentDto.DecreeNo, lawyerJudgmentDto.DecreeYear);

                if (judgment is not null)
                {

                    return false;
                }
                else
                {
                    judgment = new LawyerJudgment()
                    {
                        CommisionName = lawyerJudgmentDto.CommisionName,
                        Court = lawyerJudgmentDto.Court,
                        Decree = lawyerJudgmentDto.Decree,
                        LawyerAssessment=lawyerJudgmentDto.LawyerAssessment,
                        DecreeType = lawyerJudgmentDto.DecreeType,
                        DecreeNo = lawyerJudgmentDto.DecreeNo,
                        DecreeYear = lawyerJudgmentDto.DecreeYear,
                        MeritsNo = lawyerJudgmentDto.MeritsNo,
                        MeritsYear = lawyerJudgmentDto.MeritsYear,
                        StateId=lawyerJudgmentDto.StateId,
                        Decision=lawyerJudgmentDto.Decision,
                        TBBComments=lawyerJudgmentDto.TBBComments,
                        CreateDate=DateTime.Now,
                      
                        
                        
                        
                      

                    };


                }
                var result = _lawyerJudgmentDal.Insert(judgment);
                if (result != null)
                {
                    return true;

                }
                return false;
            }

            public bool DeleteDecree(int id)
            {
                var result = _lawyerJudgmentDal.Get(p => p.Id == id);
                _lawyerJudgmentDal.Delete(result);
                return true;
             }

            public List<LawyerJudgment> GetAll()
            {
            return new List<LawyerJudgment>(_lawyerJudgmentDal.GetAll());
        }

            public List<LawyerJudgment> GetbyKeyword(string keyword)
            {
            var result = _lawyerJudgmentDal.GetAll(p => p.Decree.Contains(keyword));
            Console.WriteLine(result);
            return result;
        }

            public ResponseDto Likes(int id)
            {
            ResponseDto response = new ResponseDto();
            var judgmentToLike = _lawyerJudgmentDal.Get(p => p.Id == id);
            if (judgmentToLike != null)
            {
                judgmentToLike.Likes++;
                _lawyerJudgmentDal.Update(judgmentToLike);
                Console.WriteLine(judgmentToLike.Likes);

                response.HasError = false;
                response.Message = judgmentToLike.Likes + "Beğeni "; //mantıksız

                return response;


            }
            else
            {
                response.HasError = true;
                response.Message = "İşlem Hatalı"; //mantıksız
                return response;

            }
        }
        }
}


