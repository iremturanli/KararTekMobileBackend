using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.Entities.Concrete;
using Karartek.Entities.Concrete.Enum;
using Karartek.Entities.Dto;
using Microsoft.Extensions.Configuration;


namespace Karartek.Business.Concrete
{
    public class JudgmentPoolService : IJudgmentPoolService

    {

        private readonly IJudgmentDal _judgmentDal;
        private readonly ILawyerJudgmentDal _lawyerJudgmentDal;
        private readonly IJudgmentPoolDal _judgmentPoolDal;





        public JudgmentPoolService(IJudgmentDal judgmentDal, ILawyerJudgmentDal lawyerJudgmentDal, IJudgmentPoolDal judgmentPoolDal, IConfiguration configuration)
        {
            _judgmentPoolDal = judgmentPoolDal;
            _judgmentDal = judgmentDal;
            _lawyerJudgmentDal = lawyerJudgmentDal;

        }

        public BaseResponseDto AddtoJudgmentPool(int userId, int judgmentId, int searchTypeId)
        {
            BaseResponseDto response = new BaseResponseDto();


            var judgmentPool = new JudgmentPool();
            if (searchTypeId == (int)ESearchTypes.AvukatınEklediğiKararlar)
            {


                {
                    var foundJudgment = _judgmentPoolDal.Get(p => p.DecisionId == judgmentId && p.UserId == userId && p.SearchTypeId == (int)ESearchTypes.AvukatınEklediğiKararlar);
                    if(foundJudgment != null)
                    {
                        response.HasError = true;
                        response.Message = "Karar Havuzunda Ekli.";
                        return response;
                    }
                    else
                    {
                        var favlawyerJudgment = _lawyerJudgmentDal.Get(p => p.Id == judgmentId);
                        judgmentPool.DecisionId = favlawyerJudgment.Id;
                        judgmentPool.UserId = userId;
                        judgmentPool.CreateDate = DateTime.Now;
                        judgmentPool.SearchTypeId = searchTypeId;

                        var resultJudgment = _judgmentPoolDal.Insert(judgmentPool);

                        response.HasError = false;
                        response.Message = "Karar Havuzunda Ekli.";
                        return response;

                    }


                 



                };
               


            }

            else

            {
                var foundJudgment = _judgmentPoolDal.Get(p => p.DecisionId == judgmentId && p.UserId == userId && p.SearchTypeId == (int)ESearchTypes.YuksekYargiKararları);
                if (foundJudgment != null)
                {
                    response.HasError = true;
                    response.Message = "Karar Havuzunda Ekli.";
                    return response;
                }
                else
                {
                    var favJudgment = _judgmentDal.Get(p => p.Id == judgmentId);
                    judgmentPool.DecisionId = favJudgment.Id;
                    judgmentPool.UserId = userId;
                    judgmentPool.CreateDate = DateTime.Now;
                    judgmentPool.SearchTypeId = searchTypeId;
                    var result = _judgmentPoolDal.Insert(judgmentPool);

                    response.HasError = false;
                    response.Message = "Karar Havuzunda Ekli.";
                    return response;


                }
                


            }





     



        }




        public BaseResponseDto DeleteFromJudgmentPool(int id,int searchTypeId,int userId)
        {
            BaseResponseDto response = new BaseResponseDto();
            var result = _judgmentPoolDal.Get(p => p.DecisionId == id && p.SearchTypeId==searchTypeId && p.UserId==userId);
            
            _judgmentPoolDal.Delete(result);
            response.HasError = false;
            response.Message = "Karar Başarıyla Silindi";
            return response;

        }



        public IDataResult<JudgmentLawyerJudgmentDto> GetAll(int userId)
        {
            JudgmentLawyerJudgmentDto judgmentLawyerJudgmentDto = new JudgmentLawyerJudgmentDto();


            var list = _judgmentPoolDal.GetAll(p => p.UserId == userId);



            if (list != null)

            {
                judgmentLawyerJudgmentDto.JudgmentResponseListDto = new List<JudgmentResponseListDto>();
                judgmentLawyerJudgmentDto.LawyerJudgmentResponseListDto = new List<LawyerJudgmentResponseListDto>();

                foreach (var item in list)
                {
                    if (item.SearchTypeId == (int)ESearchTypes.AvukatınEklediğiKararlar)
                    {
                        judgmentLawyerJudgmentDto.userId = userId;
                        LawyerJudgmentResponseListDto lawyerJudgmentResponseListDto = new LawyerJudgmentResponseListDto();
                        var result = _lawyerJudgmentDal.Get(p => p.Id == item.DecisionId);

                        lawyerJudgmentResponseListDto.Id = result.Id;
                        lawyerJudgmentResponseListDto.Decision = result.Decision;
                        lawyerJudgmentResponseListDto.CreateDate = result.CreateDate;
                        lawyerJudgmentResponseListDto.Decree = result.Decree;
                        lawyerJudgmentResponseListDto.CourtId = result.CourtId;
                        lawyerJudgmentResponseListDto.CommissionId = result.CommissionId;
                        lawyerJudgmentResponseListDto.DecreeNo = result.DecreeNo;
                        lawyerJudgmentResponseListDto.DecreeType = result.DecreeType;
                        lawyerJudgmentResponseListDto.CommissionName = result.Commission.Name;
                        lawyerJudgmentResponseListDto.CourtName = result.Court.Name;
                        lawyerJudgmentResponseListDto.DecreeYear = result.DecreeYear;
                        lawyerJudgmentResponseListDto.JudgmentDate = result.JudgmentDate;
                        lawyerJudgmentResponseListDto.LawyerAssesment = result.LawyerAssessment;
                        lawyerJudgmentResponseListDto.Likes = result.Likes;
                        lawyerJudgmentResponseListDto.UserId = userId;
                        lawyerJudgmentResponseListDto.MeritsNo = result.MeritsNo;
                        lawyerJudgmentResponseListDto.MeritsYear = result.MeritsYear;
                        lawyerJudgmentResponseListDto.StateId = result.LawyerJudgmentState.StateId;
                        lawyerJudgmentResponseListDto.UserName = result.User.FirstName;
                        lawyerJudgmentResponseListDto.LastName = result.User.LastName;
                        lawyerJudgmentResponseListDto.TBBComments = result.TBBComments == null ? String.Empty : result.TBBComments; ;
                        lawyerJudgmentResponseListDto.StateName = result.LawyerJudgmentState.StateName;




                        judgmentLawyerJudgmentDto.LawyerJudgmentResponseListDto.Add(lawyerJudgmentResponseListDto);





                    }

                    else if (item.SearchTypeId == (int)ESearchTypes.YuksekYargiKararları)
                    {
                        JudgmentResponseListDto judgmentResponseListDto = new JudgmentResponseListDto();
                        var result = _judgmentDal.Get(p => p.Id == item.DecisionId);

                        judgmentResponseListDto.Id = result.Id;
                        judgmentResponseListDto.Decision = result.Decision;
                        judgmentResponseListDto.CommissionName = result.Commission.Name;
                        judgmentResponseListDto.CourtName = result.Court.Name;
                        judgmentResponseListDto.CreateDate = result.CreateDate;
                        judgmentResponseListDto.Decree = result.Decree;
                        judgmentResponseListDto.DecreeNo = result.DecreeNo;
                        judgmentResponseListDto.DecreeType = result.DecreeType;
                        judgmentResponseListDto.CommissionId = result.Commission.Id;
                        judgmentResponseListDto.CourtId = result.CourtId;
                        judgmentResponseListDto.CreateDate = result.CreateDate;
                        judgmentResponseListDto.JudgmentDate = result.JudgmentDate;
                        judgmentResponseListDto.JudgmentTypeId = result.JudgmentTypeId;
                        judgmentResponseListDto.JudgmentTypeName = result.JudgmentType.TypeName;
                        judgmentResponseListDto.Likes = result.Likes;
                        judgmentResponseListDto.MeritsNo = result.MeritsNo;
                        judgmentResponseListDto.MeritsYear = result.MeritsYear;


                        judgmentLawyerJudgmentDto.JudgmentResponseListDto.Add(judgmentResponseListDto);

                    }

                    else
                    {
                        return new ErrorDataResult<JudgmentLawyerJudgmentDto>("Hata");

                    }


                }


                return new SuccessDataResult<JudgmentLawyerJudgmentDto>(judgmentLawyerJudgmentDto, "Success");


            }
            else
            {

                return new ErrorDataResult<JudgmentLawyerJudgmentDto>("Hata");

            }





        }

    }




}

