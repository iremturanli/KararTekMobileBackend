using System;
using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class Student:BaseEntity
    {

        public string University { get; set; } = null!;
        public string Faculty { get; set; } = null!;
        public string Grade { get; set; } = null!;
        public string StudentNumber { get; set; } = null!;
        public User? User;




    }
}

