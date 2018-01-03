using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms個人專題
{
    public partial class LogonForm : Form
    {
        public LogonForm()
        {
            InitializeComponent();
        }




        DrEntities1 dr = new DrEntities1();
        private void btnCreate_Click(object sender, EventArgs e)//創建帳號
        {
            CreateForm cf = new CreateForm();
            cf.FormClosed += Cf_FormClosed; 
            cf.Show(); this.Hide();
        }
        private void Cf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnForget_Click(object sender, EventArgs e)//忘記密碼
        {
            ForgetForm ff = new ForgetForm();
            ff.FormClosed += Ff_FormClosed;
             ff.Show(); this.Hide(); 
        }
        private void Ff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();            
        }

        private void btnLogon_Click(object sender, EventArgs e)//登入
        {
            SearchForm sf = new SearchForm();

            
            if (dr.User.Any
              (us => us.Email == Emailtext.Text && us.PassWord == Passwordtext.Text))
            {
                
                sf.Show(); sf.FormClosed += Sf_FormClosed; this.Hide();
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

        private void btnCancel_Click(object sender, EventArgs e)//關閉
        {
            Emailtext.Text = null;
            Passwordtext.Text = null;


        }
    }
}
