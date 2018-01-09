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

        private string useremail, userpassword, usergender, firsnName, lastname, lineid;

        //private string userInfo;
        //public string UserInfo
        //{
        //    get
        //    {
        //        return userInfo;
        //    }
        //    set
        //    {
        //        userInfo = value;
        //    }
        //}


        public  bool Logon(string useremail,string userpassword)
        {            
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

        

        public bool Verifyaccount(string useremil)
        {
            var userIf = new UserInformation();

            var Verifyacount = dr.User.Any(u => u.Email == useremil);
            
            return Verifyacount;
        }


    }
}
