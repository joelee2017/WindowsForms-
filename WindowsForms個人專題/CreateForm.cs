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


        
        private void UserPhoto_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                pbUserPhoto.Image = Image.FromStream(openDialog.OpenFile());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateEmailtext.Text = null;
            CreatePassWordtext.Text = null;
            CreateFirstNametext.Text = null;
            CreateLastNametext.Text = null;
            CreateLineIDtext.Text = null;
            pbUserPhoto.Image = null;
            CreateGendertext.Text = null;
        }


        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var dr = new DrEntities1();
            var NwUser = new User();
            var userIf = new UserInformation();

            var reuslt = userIf.Verifyaccount(CreateEmailtext.Text);

            if (reuslt == true)
            {
                MessageBox.Show($"{CreateEmailtext.Text} 已註冊過。");
            }
                             
            else
            {
                

                SHA256 sHA256 = SHA256.Create();
                byte[] data = sHA256.ComputeHash(Encoding.UTF8.GetBytes(CreatePassWordtext.Text));
                string hashString = "";
                for (int i = 0; i < data.Length; i++)
                {
                    hashString += data[i].ToString("x2").ToUpperInvariant();
                }


                using (var ms = new MemoryStream())
                {
                    pbUserPhoto.Image.Save(ms, ImageFormat.Jpeg);
                    NwUser.Photo = ms.ToArray();
                }
                NwUser.Email = CreateEmailtext.Text;
                NwUser.PassWord = hashString;//已加密過後
                NwUser.Gender = CreateGendertext.Text;
                NwUser.FirstName = CreateFirstNametext.Text;
                NwUser.LastName = CreateLastNametext.Text;
                NwUser.LineID = CreateLineIDtext.Text;
                dr.User.Add(NwUser);
                dr.SaveChanges();
                MessageBox.Show("ok");
            }
        }


        private void radioMan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioMan.Checked == true)
            {
                CreateGendertext.Text = "M";
            }
            else
            {
                CreateGendertext.Text = null;
            }
        }

        private void radioFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioFemale.Checked == true)
            {
                CreateGendertext.Text = "F";
            }
            else
            {
                CreateGendertext.Text = null;
            }
        }
    }
}
