using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsForms個人專題
{
    public partial class LogonForm : Form
    {
        public LogonForm()
        {
            InitializeComponent();
        }




        DrEntities1 dr = new DrEntities1();        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Emailtext.Text = null;
            Passwordtext.Text = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            {
                CreateForm cf = new CreateForm();
                cf.FormClosed += Cf_FormClosed;
                cf.Show(); this.Hide();
            }
        }
        private void Cf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            ForgetForm forgetForm = new ForgetForm();

            forgetForm.FormClosed += Ff_FormClosed;
            forgetForm.Show(); this.Hide();
        }

        private void Ff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        private void btnLogon_Click(object sender, EventArgs e)
        {
            var sf = new SearchForm();

            var encryptor = SHA256.Create();
            var data = encryptor.ComputeHash(Encoding.UTF8.GetBytes(Passwordtext.Text));
            var hashString = "";

            for (int i = 0; i < data.Length; i++)
            {
                hashString += data[i].ToString("x2").ToUpperInvariant();
            }

            if (dr.User.Any(
                us => us.Email == Emailtext.Text && us.PassWord == hashString))
            {
                sf.Show();
                sf.FormClosed += Sf_FormClosed;

                this.Hide();

                MessageBox.Show($"登入成功 {Emailtext.Text} 歡迎您!");
            }
            else
            {
                MessageBox.Show("請確認帳號密碼");
            }
        }
        private void Sf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
