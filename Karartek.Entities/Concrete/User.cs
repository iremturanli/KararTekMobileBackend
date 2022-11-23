using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int UserTypeId { get; set; }
        public int City { get; set; }
        public string? District { get; set; }
        public string IdentityNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public Student? Student;
        public Lawyer? Lawyer;
        public UserType? UserType { get; set; } = null!;
        public City_District? City_District { get; set; } = null!;
        public virtual ICollection<JudgmentPool>? JudgmentPools { get; set; } = null!;

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
