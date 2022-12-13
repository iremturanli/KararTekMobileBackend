using System;
namespace Karartek.Entities.Dto
{
    public class ChangePasswordDto
    {
        public string currentPassword { get; set; } = null!;
        public string? newPassword { get; set; } = null!;
        
    }
}
