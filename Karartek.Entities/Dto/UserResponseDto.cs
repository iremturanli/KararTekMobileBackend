namespace Karartek.Entities.Dto
{
    public class UserResponseDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int UserTypeId { get; set; }
        public int CityId { get; set; }
        public int? DistrictId { get; set; }
        public int Id { get; set; }
        public string CityName { get; set; } = null!;
        public string DistrictName { get; set; } = null!;
        public string IdentityNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string BarRegisterNo { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string University { get; set; } = null!;
        public string Faculty { get; set; } = null!;
        public string Grade { get; set; } = null!;
        public string StudentNumber { get; set; } = null!;
    }
}
