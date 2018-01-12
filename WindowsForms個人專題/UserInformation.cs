using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
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

        //Logon
        //Verifyaccount
        //CreateUser
        //ForgetVerify
        //ModifyPassword
        //FinUser
        //FindUserRecipe

        public static string UserName { get; set; }


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


        public bool CreateUser(string username, string useremail, string userpassword, string usergender, string userfirsnName, string userlastname, string userlineid,Image userPhoto,DateTime creationdate,DateTime changepassworddate)
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
                userpic.Save(ms, ImageFormat.Jpeg);
                Usertable.UserImage = ms.ToArray();
            }

            Usertable.UserName = username;
            Usertable.UserEmail = useremail;
            Usertable.UserPassword = hashpassword;
            Usertable.UserSex = usergender;
            Usertable.FirstName = userfirsnName;
            Usertable.LastName = userlastname;
            Usertable.UserLineID = userlineid;
            Usertable.CreationDate = creationdate;
            Usertable.ChangePassWorddate = changepassworddate;

            DeliciousFood.User.Add(Usertable);
            DeliciousFood.SaveChanges();

            return true;
            
        }
              

        public bool ForgetVerify(string useremail, string userlineid)
        {
            var ForgetVerify = (DeliciousFood.User.Any(u => u.UserEmail == useremail && u.UserLineID == userlineid));

            return ForgetVerify;
        }


        public bool  ModifyPassword(string Useremail, string userpassword,DateTime changepassworddate)
        {
            var Usertable = new User();
            var encryptor = SHA256.Create();

            var resultuserid = DeliciousFood.User.Where(u => u.UserEmail == Useremail).Select(s => s.UserID).SingleOrDefault();

            byte[] data = encryptor.ComputeHash(Encoding.UTF8.GetBytes(userpassword));
            string hashpassword = "";
            for (int i = 0; i < data.Length; i++)
            {
                hashpassword += data[i].ToString("x2").ToUpperInvariant();
            }

            Usertable = DeliciousFood.User.Find(resultuserid);
            Usertable.UserPassword = hashpassword;
            Usertable.ChangePassWorddate = changepassworddate;


            DeliciousFood.Entry(Usertable).State = EntityState.Modified;
            DeliciousFood.SaveChanges();



            return true;
        }

        public IEnumerable FinUser()
        {
           var result = DeliciousFood.User.Select(user => new
                        {
                            user.UserID,
                            user.UserEmail,
                            user.UserSex,
                            user.FirstName,
                            user.LastName,
                            user.UserImage,
                            user.UserLineID,

                        }).ToArray();

            return result;
        }

        public IEnumerable FindUserRecipe(int userid)
        {
            var result = DeliciousFood.Recipes.Where(u => u.UserID == userid).Select(s => new
            {
                s.RecipeId,
                s.UserID,
                s.RecipeName,
                s.Introduction,
                s.CookingTime,
                s.Amount,
                s.RecipeImage,

            }).ToArray();

            return result;
        }

    }
}
