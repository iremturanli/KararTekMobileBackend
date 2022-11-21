using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfJudgmentDal : IJudgmentDal
    {

        public void Delete(Judgment judgment)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedDecree = context.Entry(judgment);
                deletedDecree.State = EntityState.Deleted;
                context.SaveChanges();
            }


        }

        public Judgment Get(Expression<Func<Judgment, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Judgment>().SingleOrDefault(filter);
            }
        }

        public List<Judgment> GetAll(Expression<Func<Judgment, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return filter == null
                    ? context.Set<Judgment>().ToList()
                    : context.Set<Judgment>().Where(filter).ToList();

            }
        }

        public Judgment GetJudgmentByDecreeNo(string decreeNo,string decreeYear)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var judgment = context.Judgments.SingleOrDefault(x => x.DecreeNo == decreeNo&&x.DecreeYear==decreeYear);
                return judgment;


            }
        }


        public Judgment Insert(Judgment judgment)
        {
            using (AppDbContext context = new AppDbContext())
            {
                    context.Judgments.Add(judgment);
                    context.SaveChanges();
                    return judgment;
                }


          }

        public Judgment Update(Judgment judgment)
        {
            using(AppDbContext context = new AppDbContext())
            {
                context.Update(judgment);
                context.SaveChanges();

                return judgment;
            }
           
        }
    }
    }
