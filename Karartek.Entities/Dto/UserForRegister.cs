namespace Karartek.Entities.Dto
{
    public class UserForRegister
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int UserTypeId { get; set; }
        public int CityId { get; set; }
        public int? DistrictId { get; set; }
        public string IdentityNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? BarRegisterNo { get; set; } 
        public string Email { get; set; } = null!;
        public string? University { get; set; } 
        public string? Faculty { get; set; } 
        public string? Grade { get; set; } 
        public string? StudentNumber { get; set; }


    }
}
