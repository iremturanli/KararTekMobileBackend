using Core.Utilities.Results;
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
        IDataResult<List<UserResponseDto>> GetUserById(int id);
        User GetUser(int id);
        //IDataResult<List<User>> GetUserInfo(int id);
        ResponseDto ChangePassword(ChangePasswordDto changePasswordDto,int id);

    }
}
