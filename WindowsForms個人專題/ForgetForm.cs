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
    public partial class ForgetForm : Form
    {
        public ForgetForm()
        {
            InitializeComponent();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            LogonForm l1 = new LogonForm();
            l1.FormClosed += L1_FormClosed;
            l1.Show();this.Hide();
        }

        private void L1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
