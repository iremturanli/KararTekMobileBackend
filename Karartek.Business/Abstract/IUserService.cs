using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface IUserService
    {
        ResponseDto Login(UserForLogin userForLogin);
        ResponseDto Register(UserForRegister userForRegister);
        ResponseDto ForgotMyPassword(ForgotMyPasswordDto forgotMyPasswordDto);
        User GetUserByIdentity(string userIdentity);
        UserResponseDto GetUserById(int id);



    }
}
