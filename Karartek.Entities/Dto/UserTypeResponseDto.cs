using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class UserTypeResponseDto:BaseResponseDto
    {

 
        public List<UserType> UserTypes { get; set; } = null!;

    }


}
