using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mail;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Karartek.Business.Concrete
{
    public class UserService : IUserService
    {


        private readonly IUserDal _userDal;
        private readonly IConfiguration _configuration;
        private readonly IStudentDal _studentDal;
        private readonly ILawyerDal _lawyerDal;
        private string RandomPassword;
        private string NewRandomPassword;
        private string NewPassword;

        //


        public UserService(IUserDal userDal, ILawyerDal lawyerDal, IStudentDal studentDal, IConfiguration configuration)
        {
            _userDal = userDal;
            _studentDal = studentDal;
            _lawyerDal = lawyerDal;
            _configuration = configuration;
        }


        public IDataResult<List<UserResponseDto>> GetUserById(int id)

        {
            //TODO:Add remaining Dtos
            var result = _userDal.GetUserById(id);
            var listDto = new List<UserResponseDto>();
            foreach (var item in result)
            {
                var dto = new UserResponseDto()
                {
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    PhoneNumber = item.PhoneNumber,
                    BarRegisterNo = item.Lawyer == null ? String.Empty : item.Lawyer.BarRegisterNo, //profilim fakülte
                    University = item.Student == null ? String.Empty : item.Student.University,
                    UserTypeId = item.UserTypeId,
                    CityId = item.CityId,
                    DistrictId = item.DistrictId,
                    DistrictName = item.District.Name,
                    CityName = item.City.Name,
                    UserTypeName = item.UserType.TypeName,
                    Email = item.Email,
                    Faculty = item.Student == null ? String.Empty : item.Student.Faculty,
                    Grade = item.Student == null ? String.Empty : item.Student.Grade,
                    StudentNumber = item.Student == null ? String.Empty : item.Student.StudentNumber
                };
                listDto.Add(dto);
            }
            return new SuccessDataResult<List<UserResponseDto>>(listDto, "Success!");






        }

        public User GetUser(int id)
        {
            var user = _userDal.GetUserByIdObj(id);
            return user;
        }
        //IDataResult<List<User>> GetUserInfo(int id)
        //{
        //    throw new NotSupportedException();
        //}

        public User GetUserByIdentity(string identity)

        {
            return _userDal.GetUserByIdentity(identity);



        }





        public ResponseDto Login(UserForLogin userforlogin)
        {
            ResponseDto response = new ResponseDto();
            var user = _userDal.GetUserByIdentity(userforlogin.IdentityNumber);



            if (user is null)
            {
                response.HasError = true;
                response.Message = "Wrong";
                return response;



            }



            else if (!VerifyPasswordHash(userforlogin.Password, user.PasswordHash, user.PasswordSalt))
            {
                response.HasError = true;
                response.Message = "User Not Found";
                return response;
            }
            else
            {



                //We create Token here
                response.Token = CreateToken(user);
                response.HasError = false;
                response.Message = "User Found";
                return response;
            }
        }

        public ResponseDto ForgotMyPassword(ForgotMyPasswordDto forgotMyPasswordDto)
        {
            ResponseDto response = new ResponseDto();
            NewRandomPassword = GeneratePassword();
            var user = _userDal.GetUserByIdentity(forgotMyPasswordDto.IdentityNumber);

            if (user is null || user.Email != forgotMyPasswordDto.Email || user.IdentityNumber != forgotMyPasswordDto.IdentityNumber)
            {
                response.HasError = true;
                response.Message = "Bilgilerinizi kontrol ediniz."; //mantıksız
                return response;



            }

            else
            {

                CreatePasswordHash(NewRandomPassword, out byte[] passwordHash, out byte[] passwordSalt);
                var userToResetPassword = _userDal.userForForgotPassword(forgotMyPasswordDto.IdentityNumber, passwordHash, passwordSalt);


                SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress("karartek@yandex.com");
                message.To.Add(userToResetPassword.Email);
                message.Subject = "Merhaba Sayın " + userToResetPassword.FirstName + " " + userToResetPassword.LastName;
                message.Body = "Yeni uygulama şifreniz: " + NewRandomPassword + "\n" + "Şifrenizi uygulamaya girişinizin ardından Profilim menüsüne girerek değiştirebilirsiniz.";
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; // Encryption
                client.Credentials = new System.Net.NetworkCredential("karartek@yandex.com", "plbobupzzvaxxgpw");

                client.Send(message);



                //We create Token here

                response.HasError = false;
                response.Message = "Şifre Sıfırlama İşlemi Başarılı";
                return response;
            }


        }

        public ResponseDto Register(UserForRegister userForRegister)

        {
            var user = _userDal.GetUserByIdentity(userForRegister.IdentityNumber);
            ResponseDto response = new ResponseDto();

            if (user is not null)
            {
                response.HasError = true;
                response.Message = "Kimlik numarasına kayıtlı kişi mevcut"; //mantıksız
                return response;
            }

            else

            {
                RandomPassword = GeneratePassword();
                Console.WriteLine(RandomPassword);


                CreatePasswordHash(RandomPassword, out byte[] passwordHash, out byte[] passwordSalt);
                string dataToSave = Convert.ToBase64String(passwordHash);
                Console.WriteLine(dataToSave);
                user = new User()

                {

                    FirstName = userForRegister.FirstName,
                    LastName = userForRegister.LastName,
                    UserTypeId = userForRegister.UserTypeId,
                    IdentityNumber = userForRegister.IdentityNumber,
                    CityId = userForRegister.CityId,
                    DistrictId = userForRegister.DistrictId,
                    PhoneNumber = userForRegister.PhoneNumber,
                    Email = userForRegister.Email,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    CreateDate = DateTime.Now


                };
                var result = _userDal.Insert(user);


                if (userForRegister.UserTypeId == 1)
                {
                    var lawyer = new Lawyer()
                    {
                        Id = result.Id,
                        BarRegisterNo = userForRegister.BarRegisterNo,
                        CreateDate = DateTime.Now

                    };

                    var lawyerResult = _lawyerDal.Insert(lawyer);



                }
                else if (userForRegister.UserTypeId == 2)
                {

                    var student = new Student()
                    {
                        Id = result.Id,
                        StudentNumber = userForRegister.StudentNumber,
                        CreateDate = DateTime.Now,
                        University = userForRegister.University,
                        Faculty = userForRegister.Faculty

                    };

                    var studentResult = _studentDal.Insert(student);




                }



            }



            SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 587);
            MailMessage message = new MailMessage();
            message.From = new MailAddress("karartek@yandex.com");
            message.To.Add(userForRegister.Email);
            message.Subject = "Merhaba Sayın " + userForRegister.FirstName + " " + userForRegister.LastName;
            message.Body = "Karartek uygulama şifreniz: " + RandomPassword;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true; // Encryption
            client.Credentials = new System.Net.NetworkCredential("karartek@yandex.com", "plbobupzzvaxxgpw");

            client.Send(message);
            response.HasError = false;
            response.Message = "Kayıt Başarılı";
            return response;
        }


        public string GeneratePassword()
        {
            string PasswordLength = "8";
            string NewPassword = "";

            string allowedChars = "";
            allowedChars = "1,2,3,4,5,6,7,8,9,0";
            //allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            //allowedChars += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            //allowedChars += "1,2,3,4,5,6,7,8,9,0";
            //allowedChars += "!,#,$,%,&,(,),_,-,+,=,|,<,>,.,?,/";//özelkarakter


            char[] sep = {
            ','
        };
            string[] arr = allowedChars.Split(sep);


            string IDString = "";
            string temp = "";

            Random rand = new Random();

            for (int i = 0; i < Convert.ToInt32(PasswordLength); i++)
            {
                temp = arr[rand.Next(0, arr.Length)];
                IDString += temp;
                NewPassword = IDString;

            }
            return NewPassword;
        }






        // Hashing functions 
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())

            {

                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));


            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }



        ///Token Function

        private string CreateToken(User user)
        {

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var _claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Name, user.UserTypeId.ToString()),

                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var token = new JwtSecurityToken(claims: _claims,
                                             expires: DateTime.Now.AddDays(2),
                                             signingCredentials: cred);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        public ResponseDto ChangePassword(ChangePasswordDto changePasswordDto, int id)
        {

            ResponseDto response = new ResponseDto();

            NewPassword = changePasswordDto.newPassword;
            var user = _userDal.Get(p => p.Id == id);
            string userId = id.ToString();
            CreatePasswordHash(changePasswordDto.currentPassword, out byte[] passwordHash, out byte[] passwordSalt);

            if (user is null || !VerifyPasswordHash(changePasswordDto.currentPassword, user.PasswordHash, user.PasswordSalt) || user.Id != id)
            {

                response.HasError = true;
                response.Message = "Bilgilerinizi kontrol ediniz."; //mantıksız
                return response;



            }

            else
            {

                CreatePasswordHash(NewPassword, out passwordHash, out passwordSalt);
                var userToResetPassword = _userDal.userForChangePassword(id, passwordHash, passwordSalt);


                SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress("karartek@yandex.com");
                message.To.Add(userToResetPassword.Email);
                message.Subject = "Merhaba Sayın " + userToResetPassword.FirstName + " " + userToResetPassword.LastName;
                message.Body = "Yeni uygulama şifreniz: " + NewPassword;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; // Encryption
                client.Credentials = new System.Net.NetworkCredential("karartek@yandex.com", "plbobupzzvaxxgpw");

                client.Send(message);



                //We create Token here

                response.HasError = false;
                response.Message = "Şifre Sıfırlama İşlemi Başarılı";
                return response;
            }

        }
    }


}