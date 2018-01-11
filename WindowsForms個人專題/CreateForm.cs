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

        private void pbUserPhoto_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                pbUserPhoto.Image = Image.FromStream(openDialog.OpenFile());
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DeliciousFoodEntities DeliciousFood = new DeliciousFoodEntities();
            var Usertable = new User();
            var userInfo = new UserInformation();

            var reuslt = userInfo.Verifyaccount(CreateEmailtext.Text);

            if (reuslt == true)
            {
                MessageBox.Show($"{CreateEmailtext.Text} 已註冊過。");
            }
                             
            else
            {

                var result= userInfo.CreateUser(CreateNametext.Text, CreateEmailtext.Text, CreatePassWordtext.Text,
                    CreateGendertext.Text, CreateFirstNametext.Text, CreateLastNametext.Text, 
                    CreateLineIDtext.Text, pbUserPhoto.Image,DateTime.Now,DateTime.Now);


                if (result != null)
                {
                    MessageBox.Show("ok");
                }
                else
                {
                    MessageBox.Show("建置失敗");
                }

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
