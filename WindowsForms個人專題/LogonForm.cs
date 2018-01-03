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

        SearchForm sf = new SearchForm();

        DrEntities1 dr = new DrEntities1();
        private void btnCreate_Click(object sender, EventArgs e)//創建帳號
        {
            CreateForm cf = new CreateForm();
            cf.ShowDialog();
        }


        private void btnForget_Click(object sender, EventArgs e)//忘記密碼
        {

        }


        private void btnLogon_Click(object sender, EventArgs e)//登入
        {
            
            if(dr.User.Any
              (us => us.Email == Emailtext.Text && us.PassWord == Passwordtext.Text))
            {
                
                sf.ShowDialog(); sf.FormClosed += Sf_FormClosed; sf.Hide();
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

            this.Close();
        }
    }
}
