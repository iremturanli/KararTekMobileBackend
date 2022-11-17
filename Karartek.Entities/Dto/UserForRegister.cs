﻿namespace Karartek.Entities.Dto
{
    public class UserForRegister
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int UserType { get; set; } 
        public string City { get; set; } = null!;
        public string District{ get; set; } = null!;
        public string IdentityNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string BarRegisterNo { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string University{ get; set; } = null!;
        public string Faculty{ get; set; } = null!;
        public string Grade { get; set; } = null!;
        public string StudentNumber { get; set; } = null!;


    }
}
