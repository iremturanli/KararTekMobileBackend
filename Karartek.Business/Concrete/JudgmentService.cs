﻿using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Karartek.Business.Concrete

{


    public class JudgmentService : IJudgmentService

    {
        private readonly IJudgmentDal _judgmentDal;
        private readonly ILawyerJudgmentDal _lawyerjudgmentDal;

        public JudgmentService(IJudgmentDal judgmentDal, ILawyerJudgmentDal lawyerjudgmentDal)
        {
            _judgmentDal = judgmentDal;
            _lawyerjudgmentDal = lawyerjudgmentDal;
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
                    Decision = judgmentDto.Decision

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
                    CreateDate = item.CreateDate
                };

            listDto.Add(dto);


            }



            if (result!=null)
            {
               return new SuccessDataResult<List<JudgmentResponseListDto>>(listDto,"");
            }

            else
            {
                return new ErrorDataResult<List<JudgmentResponseListDto>>("Not Found");
            }


        }
        public ResponseDto Likes(int id)
        {
            ResponseDto response = new ResponseDto();
            var judgmentToLike = _judgmentDal.Get(p => p.Id == id);
            if (judgmentToLike != null)
            {
                judgmentToLike.Likes++;
                _judgmentDal.Update(judgmentToLike);
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


        /* public List<Judgment> Filter(FilterDto filterDto)
{
return new List<Judgment>(_judgmentDal.GetAll().Where(x => (String.IsNullOrEmpty(filterDto.Decree)||x.Decree.ToLower().Contains(filterDto.Decree.ToLower()))&&(String.IsNullOrEmpty(filterDto.CommisionName)||x.CommisionName.ToLower().Contains(filterDto.CommisionName.ToLower()))));
*/
    }










}

