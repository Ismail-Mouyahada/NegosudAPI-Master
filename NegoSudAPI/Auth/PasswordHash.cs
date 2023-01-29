using System.Security.Cryptography;
using System.Text;

namespace NegoSudAPI.Auth
{
    public class PasswordHash
    {

      public string HashedPass(string Password) {

            var SHA = SHA256.Create();
            var asBytesArry = Encoding.UTF8.GetBytes(Password);
            var HashedPass = SHA.ComputeHash(asBytesArry);
            return Convert.ToBase64String(HashedPass);
        
        } 
    }
}
