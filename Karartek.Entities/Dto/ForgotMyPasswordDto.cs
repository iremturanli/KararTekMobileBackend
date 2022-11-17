using System;
namespace Karartek.Entities.Dto
{
    public class ForgotMyPasswordDto
    {
        public string IdentityNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}

