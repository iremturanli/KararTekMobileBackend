using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int UserTypeId { get; set; }
        public string City { get; set; } = null!;
        public string District { get; set; } = null!;
        public string IdentityNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string BarRegisterNo { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string University { get; set; } = null!;
        public string Faculty { get; set; } = null!;
        public string Grade { get; set; } = null!;
        public string StudentNumber { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public UserType? UserType { get; set; } = null!;
    }

    /*
     *
     * 1: Oğrenci,
     * 2: Aukat,
     * 3: ... 
     * 
     * 
     */


}
