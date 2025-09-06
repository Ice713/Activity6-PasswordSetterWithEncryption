using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity6_PasswordSetterWithEncryption
{
    internal class UserAccount
    {
        private string hashedPassword;
        private readonly string encryptionKey = "MySeckretKey"; 

        public string Password
        {
            set
            {
                hashedPassword = HashPassword(value);
            }
        }

        private string HashPassword(string password)
        {
            // Simple hash simulation (not secure, just for demonstration)
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password + encryptionKey));           
        }
    }
}
