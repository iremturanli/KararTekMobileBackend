using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.Entities.Concrete;
using Karartek.Entities.Concrete.Enum;
using Karartek.Entities.Dto;

namespace Karartek.Business.Concrete
{
    public class LawyerJudgmentService : ILawyerJudgmentService
    {

        private readonly ILawyerJudgmentDal _lawyerJudgmentDal;
        private readonly IUserJudgmentStatisticDal _userJudgmentStatisticDal;
        private readonly IUserService _userService;

        public LawyerJudgmentService(ILawyerJudgmentDal lawyerJudgmentDal,IUserJudgmentStatisticDal userJudgmentStatisticDal, IUserService userService)
        {
            _lawyerJudgmentDal = lawyerJudgmentDal;
            _userJudgmentStatisticDal = userJudgmentStatisticDal;
            _userService = userService;
        }

        public BaseResponseDto AddLawyerJudgment(LawyerJudgmentDto lawyerJudgmentDto)
        {
            var judgment = _lawyerJudgmentDal.GetLawyerJudgmentByDecreeNo(lawyerJudgmentDto.DecreeNo, lawyerJudgmentDto.DecreeYear);
            BaseResponseDto response = new BaseResponseDto();

            if (judgment is not null)
            {
                response.HasError = true;
                
                
            }
            else
            {
                judgment = new LawyerJudgment()
                {
                    CommissionId = lawyerJudgmentDto.CommissionId,
                    CourtId = lawyerJudgmentDto.CourtId,
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
                    JudgmentDate = lawyerJudgmentDto.JudgmentDate,//?
                    CreateDate = DateTime.Now,
                    UserId = lawyerJudgmentDto.UserId,


                };

             

            }
            var result = _lawyerJudgmentDal.Insert(judgment);//add
            if (result != null)
            {
                var userJudgement = _userJudgmentStatisticDal.Get(p => p.UserId == judgment.UserId);
                if(userJudgement != null)
                {
                    userJudgement.JudgmentCount += 1;
                    _userJudgmentStatisticDal.Update(userJudgement);
                }
                else
                {
                var user = _userService.GetUser(judgment.UserId);

                    var statistics = new UserJudgmentStatistic()
                    {
                        UserId = user.Id,
                        UserName = user.FirstName,
                        LastName = user.LastName,
                        CityName = user.City.Name,
                        UserTypeId = user.UserTypeId,
                        UserTypeName = user.UserType.TypeName,
                        LawyerJudgmentId = judgment.Id,
                        JudgmentCount = 1
                    };

                    _userJudgmentStatisticDal.Insert(statistics);
                }

                response.HasError = false;
                return response;

            }

            response.HasError=true;
            return response;
        }

        public BaseResponseDto ApproveJudgment(JudgmentApprovalRequestDto judgmentApprovalRequestDto)
        {
            BaseResponseDto response = new BaseResponseDto();
            var judgment = _lawyerJudgmentDal.Get(p => p.Id == judgmentApprovalRequestDto.Id);



            if (judgment is not null && judgmentApprovalRequestDto.StateId == (int)EJudgmentStates.Onaylandı)
            {
                judgment.StateId = (int)EJudgmentStates.Onaylandı;
                judgment.TBBComments = "Karar Onaylandı";
                _lawyerJudgmentDal.Update(judgment);
                response.Message = "Karar onaylandı";
                response.HasError = false;

            }
            else if (judgmentApprovalRequestDto.StateId == (int)EJudgmentStates.Reddedildi)
            {
                judgment.StateId = (int)EJudgmentStates.Reddedildi;
                judgment.TBBComments = judgmentApprovalRequestDto.RejectMessage;
                _lawyerJudgmentDal.Update(judgment);
                response.Message = "Karar reddedilmiş";
                response.HasError = false;
            }
            else
            {
                response.Message = "Karar Yok";
                response.HasError = true;
            }


            return response;


        }
        public IDataResult<List<LawyerJudgmentResponseListDto>> GetLawyerJudgmentsByUserId(int id)
        {

            var result = _lawyerJudgmentDal.GetAll(p => p.UserId == id);
            var listDto = new List<LawyerJudgmentResponseListDto>();

            foreach (var item in result)
            {

                var dto = new LawyerJudgmentResponseListDto()
                {
                    CommissionName = item.Commission.Name,
                    CourtName = item.Court.Name,
                    CommissionId = item.CommissionId,
                    CourtId = item.CourtId,
                    Decision = item.Decision,
                    Decree = item.Decree,
                    DecreeNo = item.DecreeNo,
                    DecreeType = item.DecreeType,
                    DecreeYear = item.DecreeYear,
                    Id = item.Id,
                    JudgmentDate = item.JudgmentDate,
                    Likes = item.Likes,
                    MeritsNo = item.MeritsNo,
                    MeritsYear = item.MeritsYear,
                    CreateDate = item.CreateDate,
                    TBBComments = item.TBBComments,
                    UserId = item.UserId,
                    StateName = item.LawyerJudgmentState.StateName,
                    StateId = item.LawyerJudgmentState.StateId,
                    UserName = item.User.FirstName,
                    LastName = item.User.LastName,
                    LawyerAssesment = item.LawyerAssessment



                };

                listDto.Add(dto);


            }



            if (result != null)
            {
                return new SuccessDataResult<List<LawyerJudgmentResponseListDto>>(listDto, "Success!");
            }

            else
            {
                return new ErrorDataResult<List<LawyerJudgmentResponseListDto>>("Not Found");
            }


        }



        public bool DeleteDecree(int id)
        {
            var result = _lawyerJudgmentDal.Get(p => p.Id == id);
            _lawyerJudgmentDal.Delete(result);
            return true;
        }


        public IDataResult<List<LawyerJudgmentResponseListDto>> GetAllLawyerJudgments()
        {

            var result = _lawyerJudgmentDal.GetAll();
            var listDto = new List<LawyerJudgmentResponseListDto>();
   

            foreach (var item in result)
            {

                var dto = new LawyerJudgmentResponseListDto()
                {
                    CommissionName = item.Commission.Name,
                    CourtName = item.Court.Name,
                    CommissionId = item.CommissionId,
                    CourtId = item.CourtId,
                    Decision = item.Decision,
                    Decree = item.Decree,
                    DecreeNo = item.DecreeNo,
                    DecreeType = item.DecreeType,
                    DecreeYear = item.DecreeYear,
                    Id = item.Id,
                    JudgmentDate = item.JudgmentDate,
                    Likes = item.Likes,
                    MeritsNo = item.MeritsNo,
                    MeritsYear = item.MeritsYear,
                    CreateDate = item.CreateDate,
                    TBBComments = item.TBBComments,
                    UserId = item.UserId,
                    StateName = item.LawyerJudgmentState.StateName,
                    UserName = item.User.FirstName,
                    LastName = item.User.LastName,
                    LawyerAssesment = item.LawyerAssessment,
                    StateId = item.LawyerJudgmentState.StateId

                };

                listDto.Add(dto);


            }



            if (result != null)
            {
                return new SuccessDataResult<List<LawyerJudgmentResponseListDto>>(listDto, "Success!");
            }

            else
            {
                return new ErrorDataResult<List<LawyerJudgmentResponseListDto>>("Not Found");
            }


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
                    CommissionId = item.CommissionId,
                    CourtId = item.CourtId,
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

        public IDataResult<List<LawyerJudgmentResponseListDto>> GetLawyerJudgmentsByType(FilterDto filterDto)//yap
        {

            var result = _lawyerJudgmentDal.GetAll(p => p.Decree.Contains(filterDto.keyword));
            var listDto = new List<LawyerJudgmentResponseListDto>();

            foreach (var item in result)
            {

                var dto = new LawyerJudgmentResponseListDto()
                {
                    CommissionName = item.Commission.Name,
                    CourtName = item.Court.Name,
                    CommissionId = item.CommissionId,
                    CourtId = item.CourtId,
                    Decision = item.Decision,
                    Decree = item.Decree,
                    DecreeNo = item.DecreeNo,
                    DecreeType = item.DecreeType,
                    DecreeYear = item.DecreeYear,
                    Id = item.Id,
                    JudgmentDate = item.JudgmentDate,
                    Likes = item.Likes,
                    MeritsNo = item.MeritsNo,
                    MeritsYear = item.MeritsYear,
                    CreateDate = item.CreateDate,
                    TBBComments = item.TBBComments,
                    UserId = item.UserId,
                    StateName = item.LawyerJudgmentState.StateName,
                    UserName = item.User.FirstName,
                    LastName = item.User.LastName,
                    LawyerAssesment = item.LawyerAssessment

                };

                listDto.Add(dto);


            }

            if (result != null)
            {
                return new SuccessDataResult<List<LawyerJudgmentResponseListDto>>(listDto, "");
            }

            else
            {
                return new ErrorDataResult<List<LawyerJudgmentResponseListDto>>("Not Found");
            }
        }


        public IResult Likes(int id, bool check)
        {
            var judgmentToLike = _lawyerJudgmentDal.Get(p => p.Id == id);
            if (judgmentToLike != null)
            {
                if (check == true)
                {

                    judgmentToLike.Likes++;
                    _lawyerJudgmentDal.Update(judgmentToLike);
                    Console.WriteLine(judgmentToLike.Likes);
                    return new SuccessResult("Success!");

                }
                else
                {

                    judgmentToLike.Likes--;
                    _lawyerJudgmentDal.Update(judgmentToLike);
                    Console.WriteLine(judgmentToLike.Likes);
                    return new SuccessResult("Likes count decreased");
                }



            }
            else
            {
                return new ErrorResult("Failed");

            }


        }
    }
}

