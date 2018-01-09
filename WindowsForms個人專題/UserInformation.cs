using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms個人專題
{
    public class UserInformation
    {
        DrEntities1 dr = new DrEntities1();

        private string useremail, userpassword, usergender, userfirsnName, userlastname, userlineid, userPhoto;

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


        public bool Logon(string useremail, string userpassword)
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
            var userInfo = new UserInformation();

            var Verifyacount = dr.User.Any(u => u.Email == useremil);

            return Verifyacount;
        }
        

        public bool CreateUser(string useremail, string userpassword, string usergender, string userfirsnName, string userlastname, string userlineid, string userPhoto)
        {
            var dr = new DrEntities1();
            var Usertable = new User();
            var encryptor = SHA256.Create();

            byte[] data = encryptor.ComputeHash(Encoding.UTF8.GetBytes(userpassword));
            string hashpassword = "";
            for (int i = 0; i < data.Length; i++)
            {
                hashpassword += data[i].ToString("x2").ToUpperInvariant();
            }
            
            using (var ms = new MemoryStream())
            using(var userpic = new Bitmap(userPhoto))
            {
                userpic.Save(ms, ImageFormat.Jpeg);
                
            }

            Usertable.Email = useremail;
            Usertable.PassWord = hashpassword;
            Usertable.Gender = usergender;
            Usertable.FirstName = userfirsnName;
            Usertable.LastName = userlastname;
            Usertable.LineID = userlineid;
            dr.User.Add(Usertable);
            dr.SaveChanges();

           
            return 
        }
    }
}
