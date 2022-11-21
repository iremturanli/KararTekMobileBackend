using System;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface IStudentDal
    {
        Student Insert(Student student);
    }
}

