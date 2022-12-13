using System;
namespace Karartek.Entities.Dto
{
    public class ForgotMyPasswordDto
    {
        public string IdentityNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
