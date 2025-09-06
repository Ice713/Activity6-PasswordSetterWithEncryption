using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity6_PasswordSetterWithEncryption
{
    internal class UserAccount
    {
        private string encryptedPassword;
        private readonly string encryptionKey = "MySeckretKey"; 

        public string Password
        {
            set
            {
                encryptedPassword = EncryptPassword(value);
            }
        }

        private string EncryptPassword(string password)
        {
            var encryptedChars = password.Select((c, i) => (char)(c ^ encryptionKey[i % encryptionKey.Length])).ToArray();
            return new string(encryptedChars);
        }
    }
}
