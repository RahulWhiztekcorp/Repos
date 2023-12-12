using EncryptANDDecryptWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace EncryptANDDecryptWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("Signin")]
        public User Signin(User user)
        {
            return user;
        }
        [HttpPost("EncryptUser")]
        public User EncryptUser(User user)
        {
            try
            {
                byte[] encUserNameData_byte = new byte[user.Username.Length];
                byte[] encPassWordData_byte = new byte[user.Password.Length];
                encUserNameData_byte = Encoding.UTF8.GetBytes(user.Username);
                encPassWordData_byte = Encoding.UTF8.GetBytes(user.Password);
                User u = new User();
                u.Username = Convert.ToBase64String(encUserNameData_byte);
                u.Password = Convert.ToBase64String(encPassWordData_byte);
                return u;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        [HttpPost("DecryptUser")]
        public User DecryptUser(User user)
        {
            try
            {
                UTF8Encoding encoder = new UTF8Encoding();
                Decoder utf8Decode = encoder.GetDecoder();
                byte[] UserNametodecode_byte = Convert.FromBase64String(user.Username);
                byte[] Passwordtodecode_byte = Convert.FromBase64String(user.Password);
                int UNcharCount = utf8Decode.GetCharCount(UserNametodecode_byte, 0, UserNametodecode_byte.Length);
                int PWcharCount = utf8Decode.GetCharCount(Passwordtodecode_byte, 0, Passwordtodecode_byte.Length);
                char[] UNdecoded_char = new char[UNcharCount];
                char[] PWdecoded_char = new char[PWcharCount];
                utf8Decode.GetChars(UserNametodecode_byte, 0, UNdecoded_char.Length, UNdecoded_char, 0);
                utf8Decode.GetChars(Passwordtodecode_byte, 0, PWdecoded_char.Length, PWdecoded_char, 0);
                user.Username = new String(UNdecoded_char);
                user.Password = new String(PWdecoded_char);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
    }
}
