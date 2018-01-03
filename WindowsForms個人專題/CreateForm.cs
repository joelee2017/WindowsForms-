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

        DrEntities1 dr = new DrEntities1();//資料庫建立實體
        User NwUser = new User();//資料表建立實體       

        //Return返迴logon
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

        //打開檔案(圖片)
        OpenFileDialog od = new OpenFileDialog();
        private void UserPhoto_Click(object sender, EventArgs e)
        {
            if (od.ShowDialog() == DialogResult.OK)
            {
                UserPhoto.Image = Image.FromStream(od.OpenFile());
            }
        }

        //清除所有欄位值
        private void button2_Click(object sender, EventArgs e)
        {
            Emailtext.Text = null;
            PassWordtext.Text = null;
            FirstNametext.Text = null;
            LastNametext.Text = null;
            LineIDtext.Text = null;
            UserPhoto.Image = null;
        }

        //性別男
        private void radioMan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMan.Checked == true)
            {
                Gendertext.Text = "M";
            }
            else
            {
                Gendertext.Text = null;
            }
        }

        //性別女
        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFemale.Checked == true)
            {
                Gendertext.Text = "F";
            }
            else
            {
                Gendertext.Text = null;
            }
        }

        //新增帳號
        private void btnCreate_Click(object sender, EventArgs e)
        {

            SHA256 sha256 = new SHA256CryptoServiceProvider();//建立SHA256
            byte[] source = Encoding.Default.GetBytes(PassWordtext.Text);//字串轉為byte[]
            byte[] crypto = sha256.ComputeHash(source);//進行SHA256加密
            string resultpa = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串

            using (var ms = new MemoryStream())
            {
                UserPhoto.Image.Save(ms, ImageFormat.Jpeg);
                NwUser.Photo = ms.ToArray();
            }

                NwUser.Email = Emailtext.Text;
                NwUser.PassWord = resultpa;//已加密過後
                NwUser.Gender = Gendertext.Text;
                NwUser.FirstName = FirstNametext.Text;
                NwUser.LastName = LastNametext.Text;

                NwUser.LineID = LineIDtext.Text;
                dr.User.Add(NwUser);
                dr.SaveChanges();
                MessageBox.Show("ok");
        }
      
    }
}
