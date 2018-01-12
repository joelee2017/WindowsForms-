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

        UserInformation userInfo = new UserInformation();

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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            forgetemiltext.Text = null;
            forgetlineidtext.Text = null;
            forgetlnewpasswordtext.Text = null;
            forgetlcheckpasswordtext.Text = null;
        }


        private void btnForget_Click(object sender, EventArgs e)
        {

            var Verifyresult = userInfo.ForgetVerify(forgetemiltext.Text, forgetlineidtext.Text);
            
                if (Verifyresult == true)
                {
                    forgetlnewpasswordtext.Enabled = true;
                    forgetlcheckpasswordtext.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"請確認 {forgetemiltext.Text} 和 {forgetlineidtext.Text} 是否有誤");
                }           
            
        }

        private void btnPassWoardModify_Click(object sender, EventArgs e)
        {
            if(forgetlnewpasswordtext.Text== forgetlcheckpasswordtext.Text)
            {
                var result = userInfo.ModifyPassword(forgetemiltext.Text, forgetlcheckpasswordtext.Text,DateTime.Now);

                if (result == true)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("失敗");
                }
            }
            else
            {
                MessageBox.Show("輸入的密碼需一致");
            }
        }
    }
}
