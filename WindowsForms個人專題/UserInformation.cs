using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms個人專題
{
    public class UserInformation
    {
        DrEntities1 dr = new DrEntities1();


        string useremail, userpassword;

        private string userInfo;
        public string UserInfo
        {
            get
            {
                return userInfo;
            }
            set
            {

            }
        }


        public  bool Logon(string useremail,string userpassword)
        {
            var searchForm = new SearchForm();

            var encryptor = SHA256.Create();
            var data = encryptor.ComputeHash(Encoding.UTF8.GetBytes(userpassword));
            var hashpassword = "";

            for (int i = 0; i < data.Length; i++)
            {
                hashpassword += data[i].ToString("x2").ToUpperInvariant();
            }

            
            var LogonInfo = dr.User.Any(us => us.Email == useremail && us.PassWord == hashpassword);

            return LogonInfo;
        }

    }
}
