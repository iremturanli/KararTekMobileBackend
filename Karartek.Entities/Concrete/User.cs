using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int UserTypeId { get; set; }
        public int CityId { get; set; }
        public int? DistrictId { get; set; }
        public string IdentityNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public Student? Student;
        public Lawyer? Lawyer;
        public UserType? UserType { get; set; } = null!;
        public virtual ICollection<JudgmentPool>? JudgmentPools { get; set; } = null!;
        public City City { get; set; }
        //public District District { get; set; }

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
