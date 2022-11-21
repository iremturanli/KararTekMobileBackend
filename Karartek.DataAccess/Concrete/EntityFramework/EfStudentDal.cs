using System;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfStudentDal : IStudentDal
    {
        public Student Insert(Student student)
        {
            using var context = new AppDbContext();
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }
    }
}

