using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace WindowsForms個人專題
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        DrEntities1 dr = new DrEntities1();
        User NwUser = new User();     



        private void btnReturn_Click(object sender, EventArgs e)
        {
            LogonForm lf1 = new LogonForm();
            lf1.FormClosed += Lf1_FormClosed;
            lf1.Show(); this.Hide();
            
        }
        private void Lf1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        OpenFileDialog od = new OpenFileDialog();
        private void UserPhoto_Click(object sender, EventArgs e)
        {
            if (od.ShowDialog() == DialogResult.OK)
            {
                pbUserPhoto.Image = Image.FromStream(od.OpenFile());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textEmail.Text = null;
            textPassWord.Text = null;
            textFirstName.Text = null;
            textLastName.Text = null;
            textLineID.Text = null;
            pbUserPhoto.Image = null;
            textGender.Text = null;
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {


            if (dr.User.Any(u => u.Email == textEmail.Text))
            {
                MessageBox.Show($"{textEmail.Text} 已註冊過。");
            }
                             
            else
            {
                #region 雜湊方法(一)
                //SHA256 sha256 = new SHA256CryptoServiceProvider();//建立SHA256
                //byte[] source = Encoding.Default.GetBytes(PassWordtext.Text);//字串轉為byte[]
                //byte[] crypto = sha256.ComputeHash(source);//進行SHA256加密
                //string resultpa = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串
                #endregion

                #region 雜湊方法(二)
                SHA256 sHA256 = SHA256.Create();
                byte[] data = sHA256.ComputeHash(Encoding.UTF8.GetBytes(textPassWord.Text));
                string hashString = "";
                for (int i = 0; i < data.Length; i++)
                {
                    hashString += data[i].ToString("x2").ToUpperInvariant();
                }
                #endregion

                using (var ms = new MemoryStream())
                {
                    pbUserPhoto.Image.Save(ms, ImageFormat.Jpeg);
                    NwUser.Photo = ms.ToArray();
                }
                NwUser.Email = textEmail.Text;
                NwUser.PassWord = hashString;//已加密過後
                NwUser.Gender = textGender.Text;
                NwUser.FirstName = textFirstName.Text;
                NwUser.LastName = textLastName.Text;
                NwUser.LineID = textLineID.Text;
                dr.User.Add(NwUser);
                dr.SaveChanges();
                MessageBox.Show("ok");
            }
        }


        private void radioMan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioMan.Checked == true)
            {
                textGender.Text = "M";
            }
            else
            {
                textGender.Text = null;
            }
        }

        private void radioFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioFemale.Checked == true)
            {
                textGender.Text = "F";
            }
            else
            {
                textGender.Text = null;
            }
        }
    }
}
