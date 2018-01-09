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

        DeliciousFoodEntities DeliciousFood = new DeliciousFoodEntities();

        private string userename, useremail, userpassword, usergender, userfirsnName, userlastname, userlineid, userPhoto;


        public bool Logon(string useremail, string userpassword)
        {
            var encryptor = SHA256.Create();
            var data = encryptor.ComputeHash(Encoding.UTF8.GetBytes(userpassword));
            var hashpassword = "";


            for (int i = 0; i < data.Length; i++)
            {
                hashpassword += data[i].ToString("x2").ToUpperInvariant();
            }

            var LogonInfo = DeliciousFood.User.Any(us => us.UserEmail == useremail && us.UserPassword == hashpassword);

            return LogonInfo;
        }



        public bool Verifyaccount(string useremil)
        {
            var userInfo = new UserInformation();

            var Verifyacount = DeliciousFood.User.Any(u => u.UserEmail == useremil);

            return Verifyacount;
        }


        public string CreateUser(string username, string useremail, string userpassword, string usergender, string userfirsnName, string userlastname, string userlineid,Image userPhoto)
        {

            var Usertable = new User();
            var encryptor = SHA256.Create();

            byte[] data = encryptor.ComputeHash(Encoding.UTF8.GetBytes(userpassword));
            string hashpassword = "";
            for (int i = 0; i < data.Length; i++)
            {
                hashpassword += data[i].ToString("x2").ToUpperInvariant();
            }
            
            using(var ms =new MemoryStream())
            using(var userpic = new Bitmap(userPhoto))
            {
                //userpic.Save(ms, ImageFormat.Jpeg);
                Usertable.UserImage = ms;
            }

            Usertable.UserName = username;
            Usertable.UserEmail = useremail;
            Usertable.UserPassword = hashpassword;
            Usertable.UserSex = usergender;
            Usertable.FirstName = userfirsnName;
            Usertable.LastName = userlastname;
            Usertable.UserLineID = userlineid;
            DeliciousFood.User.Add(Usertable);
            DeliciousFood.SaveChanges();



            return DeliciousFood.ToString();
        }
    }
}
