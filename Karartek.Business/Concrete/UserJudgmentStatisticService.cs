using System;
using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.Extensions.Configuration;

namespace Karartek.Business.Concrete
{
    public class UserJudgmentStatisticService:IUserJudgmentStatisticService
    {
        private readonly IUserJudgmentStatisticDal _userJudgmentStatisticDal;
      

        


        public UserJudgmentStatisticService(IUserJudgmentStatisticDal userJudgmentStatisticDal)
        {
            _userJudgmentStatisticDal = userJudgmentStatisticDal;
        }




        public IDataResult <List<UserJudgmentStatistic>> GetAll()
        {
            var result = _userJudgmentStatisticDal.GetAll();
            if (result != null)
            {
                return new SuccessDataResult<List<UserJudgmentStatistic>>(result,"Success");

            }
            else
                return new ErrorDataResult<List<UserJudgmentStatistic>>("Not Found");

        }
        public IDataResult<List<UserJudgmentStatistic>> GetAllbyKeyword(FilterStatisticDto filterStatisticDto)

        {
            String keyword = filterStatisticDto.keyword.ToLower();
            var result=_userJudgmentStatisticDal.GetAll();
            if((keyword == null)||(keyword==""))
            {
                result = _userJudgmentStatisticDal.GetAll();
            }
            else 
            {
                result = _userJudgmentStatisticDal.GetAll(p => (p.UserName.Contains(keyword)) || (p.LastName.Contains(keyword))
                || ((p.UserName + " " + p.LastName).Contains(keyword)) || (p.CityName.Contains(keyword)) || (p.JudgmentCount.ToString() == keyword));
            }
           
            if (result != null)
            {
                return new SuccessDataResult<List<UserJudgmentStatistic>>(result, "Success");

            }
            else
                return new ErrorDataResult<List<UserJudgmentStatistic>>("Not Found");

        }


    }
}

