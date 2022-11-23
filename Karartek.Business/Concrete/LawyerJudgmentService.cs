using System;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.Entities.Concrete;
using Karartek.Entities.Concrete.Enum;
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
                    LawyerAssessment = lawyerJudgmentDto.LawyerAssessment,
                    DecreeType = lawyerJudgmentDto.DecreeType,
                    DecreeNo = lawyerJudgmentDto.DecreeNo,
                    DecreeYear = lawyerJudgmentDto.DecreeYear,
                    MeritsNo = lawyerJudgmentDto.MeritsNo,
                    MeritsYear = lawyerJudgmentDto.MeritsYear,
                    StateId = (int)EJudgmentStates.OnayBekliyor,
                    Decision = lawyerJudgmentDto.Decision,
                    TBBComments = lawyerJudgmentDto.TBBComments,
                    CreateDate = DateTime.Now,






                };


            }
            var result = _lawyerJudgmentDal.Insert(judgment);//add
            if (result != null)
            {
                return true;

            }
            return false;
        }

        public ResponseDto ApproveJudgment(int id)
        {
            ResponseDto response = new ResponseDto();
            var judgment = _lawyerJudgmentDal.Get(p => p.Id == id);
            if (judgment.StateId == (int)EJudgmentStates.OnayBekliyor)
            {
                judgment.StateId = (int)EJudgmentStates.Onaylandı;
                _lawyerJudgmentDal.Update(judgment);


            }
            else

                response.HasError = true;
            response.Message = "Hatalı ";

            return response;





        }

     

        public ResponseDto DeclineJudgment(int id, string comment)
        {
            ResponseDto response = new ResponseDto();
            var judgment = _lawyerJudgmentDal.Get(p => p.Id == id);
            if (judgment.StateId == (int)EJudgmentStates.OnayBekliyor)
            {
                judgment.StateId = (int)EJudgmentStates.Reddedildi;
                judgment.TBBComments = comment;
                _lawyerJudgmentDal.Update(judgment);



            }
            else

            response.HasError = true;
            response.Message = "Hatalı ";

            return response;
        }




        public bool DeleteDecree(int id)
        {
            var result = _lawyerJudgmentDal.Get(p => p.Id == id);
            _lawyerJudgmentDal.Delete(result);
            return true;
        }

        public List<LawyerJudgmentDto> GetAll()
        {
            var data = new List<LawyerJudgmentDto>();
            var result = _lawyerJudgmentDal.GetAll();

            foreach (var item in result)
            {
                var dto = new LawyerJudgmentDto()
                {
                    Id = item.Id,
                    CommisionName = item.CommisionName,
                    Court = item.Court,
                    Decision = item.Decision,
                    Decree = item.Decree,
                    DecreeNo = item.DecreeNo,
                    DecreeType = item.DecreeType,
                    DecreeYear = item.DecreeYear,
                    LawyerAssessment = item.LawyerAssessment,
                    Likes = item.Likes,
                    MeritsNo = item.MeritsNo,
                    MeritsYear = item.MeritsYear,
                    StateId = item.StateId,
                    TBBComments = item.TBBComments

                };

                data.Add(dto);
            }


            return data;
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


