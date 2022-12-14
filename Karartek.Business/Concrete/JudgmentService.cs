using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using Karartek.Entities.Concrete.Enum;
using Karartek.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Karartek.Business.Concrete

{


    public class JudgmentService : IJudgmentService

    {
        private readonly IJudgmentDal _judgmentDal;
        private readonly ILawyerJudgmentDal _lawyerjudgmentDal;
        private readonly IUserLikeDal _userLikeDal;

        public JudgmentService(IJudgmentDal judgmentDal, ILawyerJudgmentDal lawyerjudgmentDal,IUserLikeDal userLikeDal)
        {
            _judgmentDal = judgmentDal;
            _lawyerjudgmentDal = lawyerjudgmentDal;
            _userLikeDal = userLikeDal;
        }

        public bool AddJudgment(JudgmentDto judgmentDto)

        {
            var judgment = _judgmentDal.GetJudgmentByDecreeNo(judgmentDto.DecreeNo, judgmentDto.DecreeYear);

            if (judgment is not null)
            {

                return false;
            }
            else
            {
                judgment = new Judgment()
                {
                    CommissionId = judgmentDto.CommissionId,
                    CourtId = judgmentDto.CourtId,
                    Decree = judgmentDto.Decree,
                    DecreeType = judgmentDto.DecreeType,
                    DecreeNo = judgmentDto.DecreeNo,
                    DecreeYear = judgmentDto.DecreeYear,
                    MeritsNo = judgmentDto.MeritsNo,
                    MeritsYear = judgmentDto.MeritsYear,
                    JudgmentTypeId = judgmentDto.JudgmentTypeId,
                    JudgmentDate=judgmentDto.JudgmentDate,
                    Decision = judgmentDto.Decision,
                    CreateDate=DateTime.Now

     

                };


            }
            var result = _judgmentDal.Insert(judgment);
            if (result != null)
            {
                return true;

            }
            return false;
        }

        public bool DeleteDecree(int id)
        {
            var result = _judgmentDal.Get(p => p.Id == id);
            _judgmentDal.Delete(result);
            return true;
        }

        public List<Judgment> GetAll()
        {
            return new List<Judgment>(_judgmentDal.GetAll());
        }

        public List<Judgment> GetbyKeyword(string keyword)
        {
            var result = _judgmentDal.GetAll(p => p.Decree.Contains(keyword));
            Console.WriteLine(result);
            return result;
        }

        public IDataResult <List<JudgmentResponseListDto>> GetJudgmentsByType(FilterDto filterDto)
        {

            var result = _judgmentDal.GetAll(p=>p.JudgmentTypeId==filterDto.judgmentTypeId && p.Decree.Contains(filterDto.keyword));
            var listDto = new List<JudgmentResponseListDto>();
        
            foreach (var item in result){

                var dto = new JudgmentResponseListDto()
                {
                    CommissionName = item.Commission.Name,
                    CourtName = item.Court.Name,
                    JudgmentTypeName = item.JudgmentType.TypeName,
                    CommissionId = item.CommissionId,
                    CourtId = item.CourtId,
                    Decision = item.Decision,
                    Decree = item.Decree,
                    DecreeNo = item.DecreeNo,
                    DecreeType = item.DecreeType,
                    DecreeYear = item.DecreeYear,
                    Id = item.Id,
                    JudgmentDate = item.JudgmentDate,
                    JudgmentTypeId = item.JudgmentTypeId,
                    Likes = item.Likes,
                    MeritsNo = item.MeritsNo,
                    MeritsYear = item.MeritsYear,
                    CreateDate = item.CreateDate,
               
                  
                };

            listDto.Add(dto);


            }



            if (result!=null)
            {
               return new SuccessDataResult<List<JudgmentResponseListDto>>(listDto,"Success!");
            }

            else
            {
                return new ErrorDataResult<List<JudgmentResponseListDto>>("Not Found");
            }


        }

        

        public IResult Likes(int id, bool check,int userId)
        {
            var judgmentToLike = _judgmentDal.Get(p => p.Id == id);
            var userLikes = new UserLike();
            if (judgmentToLike != null)
            {
                if(check==true)
                {
                    
                    judgmentToLike.Likes++;
                    _judgmentDal.Update(judgmentToLike);
                    Console.WriteLine(judgmentToLike.Likes);

                    var foundUserLikes = _userLikeDal.Get(p => p.UserId == userId && p.JudgmentId == judgmentToLike.Id && p.TypeId==(int)ESearchTypes.YuksekYargiKararları);
                    if (foundUserLikes != null)
                    {

                        return new ErrorResult("Veritabanında kayıtlı");
                    }
                    else
                    {
                        userLikes.UserId = userId;
                        userLikes.isLike = true;
                        userLikes.JudgmentId = judgmentToLike.Id;
                        userLikes.TypeId = (int)ESearchTypes.YuksekYargiKararları;
                        _userLikeDal.Insert(userLikes);
                        return new SuccessResult("Success!");

                    }
                    

             

                }
                else
                {

                    judgmentToLike.Likes--;
                    _judgmentDal.Update(judgmentToLike);
                    Console.WriteLine(judgmentToLike.Likes);


                    var foundUserLikes = _userLikeDal.Get(p => p.UserId == userId && p.JudgmentId == judgmentToLike.Id && p.TypeId==(int)ESearchTypes.YuksekYargiKararları); //bunu da değiştir şimde dene
                    _userLikeDal.Delete(foundUserLikes);
                    //foundUserLikes.isLike = false;
                    //_userLikeDal.Update(foundUserLikes);
                    return new SuccessResult("Likes count decreased");
                 
                }



            }
            else
            {
                return new ErrorResult("Failed");

            }

        }
        public Judgment GetbyId(int id)
        {
            var result = _judgmentDal.Get(p => p.Id==id);
            return result;
        }

        public IDataResult<List<JudgmentResponseListDto>> GetJudgmentsByDetailSearch(GetJudgmentByDetailSearchDto detailSearchDto)
        {
            if (detailSearchDto.courtId == 0) { detailSearchDto.courtId = null; }
            if (detailSearchDto.commissionId == 0) { detailSearchDto.commissionId = null; }
            var resultFilter = _judgmentDal.GetAll().Where(result => (result.JudgmentTypeId==detailSearchDto.judgmentTypeId)
            &&((result.Decree.Contains(detailSearchDto.keyword)) || (String.IsNullOrEmpty(detailSearchDto.keyword)) || (result.DecreeType.Contains(detailSearchDto.keyword)))
            && ((String.IsNullOrEmpty(detailSearchDto.commissionId.ToString()) || (result.CommissionId == detailSearchDto.commissionId)))
            && ((String.IsNullOrEmpty(detailSearchDto.courtId.ToString()) || (result.CourtId == detailSearchDto.courtId)))
            && ((String.IsNullOrEmpty(detailSearchDto.meritsYear) || (result.MeritsYear == detailSearchDto.meritsYear)))
            && ((String.IsNullOrEmpty(detailSearchDto.meritsFirstOrder)) || (int.Parse(result.MeritsNo) >= int.Parse(detailSearchDto.meritsFirstOrder)))
            && ((String.IsNullOrEmpty(detailSearchDto.meritsLastOrder)) || (int.Parse(result.MeritsNo) >= int.Parse(detailSearchDto.meritsLastOrder)))
            && ((String.IsNullOrEmpty(detailSearchDto.decreeYear) || (result.DecreeYear == detailSearchDto.decreeYear)))
            && ((String.IsNullOrEmpty(detailSearchDto.decreeFirstOrder)) || (int.Parse(result.DecreeNo) >= int.Parse(detailSearchDto.decreeFirstOrder)))
            && ((String.IsNullOrEmpty(detailSearchDto.decreeLastOrder)) || (int.Parse(result.DecreeNo) >= int.Parse(detailSearchDto.decreeLastOrder)))
            && (!detailSearchDto.firstDate.HasValue || result.JudgmentDate >= detailSearchDto.firstDate)
            && (!detailSearchDto.lastDate.HasValue || result.JudgmentDate <= detailSearchDto.lastDate)
            

            );


            var listDto = new List<JudgmentResponseListDto>();

            foreach (var item in resultFilter)
            {

                var dto = new JudgmentResponseListDto()
                {
                    CommissionName = item.Commission.Name == null ? String.Empty : item.Commission.Name,
                    CourtName = item.Court.Name,
                    JudgmentTypeName = item.JudgmentType.TypeName==null ? String.Empty: item.JudgmentType.TypeName,
                    CommissionId = item.CommissionId,
                    CourtId = item.CourtId,
                    Decision = item.Decision,
                    Decree = item.Decree,
                    DecreeNo = item.DecreeNo,
                    DecreeType = item.DecreeType,
                    DecreeYear = item.DecreeYear,
                    Id = item.Id,
                    JudgmentDate = item.JudgmentDate,
                    JudgmentTypeId = item.JudgmentTypeId,
                    Likes = item.Likes,
                    MeritsNo = item.MeritsNo,
                    MeritsYear = item.MeritsYear,
                    CreateDate = item.CreateDate,


                };

                listDto.Add(dto);


            }



            if (resultFilter != null)
            {
                return new SuccessDataResult<List<JudgmentResponseListDto>>(listDto, "Success!");
            }

            else
            {
                return new ErrorDataResult<List<JudgmentResponseListDto>>("Not Found");
            }





        }

        //public IDataResult<List<JudgmentResponseListDto>> GetFilteredJudgmentsResult(FilterSearchResultsJudgmentDto filterSearchResultsDto)
        //{
            

        //    var resultsFilter = filterSearchResultsDto.JudgmentResponseListDto;
        //    var results = resultsFilter;
            

        //    if(resultsFilter != null)
        //    {
        //        if (filterSearchResultsDto.OrderItem == 1)
        //        {
        //           results= resultsFilter.OrderByDescending(x =>x.JudgmentDate).ToList();
        //        }
        //        else if (filterSearchResultsDto.OrderItem == 2)
        //        {
        //           results= resultsFilter.OrderByDescending(x => x.Likes).ToList();
        //        }
        //        else 
        //        {
        //            results = resultsFilter.ToList();
        //        }

        //        if (filterSearchResultsDto.CourtId == 0) { filterSearchResultsDto.CourtId = null; }
        //        if (filterSearchResultsDto.CommissionId == 0) { filterSearchResultsDto.CommissionId = null; }

        //        var resultFilter = results.Where(x => (x.Decree.Contains(filterSearchResultsDto.ke)));
        //    }

            
        //}
    }










}

