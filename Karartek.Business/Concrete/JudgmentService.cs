﻿using Karartek.Business.Abstract;
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

        public JudgmentService(IJudgmentDal judgmentDal)
        {
            _judgmentDal = judgmentDal;
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
                    CommisionName = judgmentDto.CommisionName,
                    Court = judgmentDto.Court,
                    Decree = judgmentDto.Decree,
                    DecreeType = judgmentDto.DecreeType,
                    DecreeNo = judgmentDto.DecreeNo,
                    DecreeYear = judgmentDto.DecreeYear,
                    MeritsNo = judgmentDto.MeritsNo,
                    MeritsYear = judgmentDto.MeritsYear,         
                                    
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
            Console.WriteLine(  result);
            return result;
        }


        
    }
}

 