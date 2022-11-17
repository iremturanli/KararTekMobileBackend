using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface IUserService
    {
        ResponseDto Login(UserForLogin userForLogin);
        bool Register(UserForRegister userForRegister);
    }
}
