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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateForm create = new CreateForm();
            create.ShowDialog();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            

            if(dr.User.Any(us => us.Email == Emailtext.Text && us.PassWord == Passwordtext.Text))
            {
                SearchForm sf = new SearchForm();
                sf.ShowDialog();
            }
            else
            {
                MessageBox.Show("請確認帳號密碼");
            }

              
        }
    }
}
