using System.Security.Cryptography;
using System.Text;

namespace NegoSudAPI.Auth
{
    public class PasswordHash
    {

        public string? HashedPass(string? password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(nameof(password), "Le paramètre ne peut pas être nul.");
            }

            var SHA = SHA256.Create();
            var asBytesArry = Encoding.UTF8.GetBytes(password);
            var HashedPass = SHA.ComputeHash(asBytesArry);

            return Convert.ToBase64String(HashedPass);


        }
    }
}
