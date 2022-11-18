using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class UserTypeResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; }
        public List<UserType> UserTypes { get; set; } = null!;

    }


}
