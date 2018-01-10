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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            forgetemiltext.Text = null;
            forgetlineidtext.Text = null;
        }


        private void btnForget_Click(object sender, EventArgs e)
        {
            DeliciousFoodEntities DeliciousFood = new DeliciousFoodEntities();

            var userInfo = new UserInformation();

            var Verifyresult = userInfo.ForgetVerify(forgetemiltext.Text, forgetlineidtext.Text);

            var returnresult = userInfo.ReturnPassword(forgetemiltext.Text, forgetlineidtext.Text);


                if (Verifyresult == true)
                {
                    forgetpasswordlabel.Text = returnresult;
                }
                else
                {
                    MessageBox.Show($"請確認 {forgetemiltext.Text} 和 {forgetlineidtext.Text} 是否有誤");
                }
            
            
        }

    }
}
