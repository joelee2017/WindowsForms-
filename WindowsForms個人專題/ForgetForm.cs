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
        

        //Return返迴登入頁面
        private void btnreturn_Click(object sender, EventArgs e)
        {
            LogonForm l1 = new LogonForm();
            l1.FormClosed += L1_FormClosed;
            l1.Show();this.Hide();
        }
        //Return關閉隱藏畫面
        private void L1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        //Cancel清除輸入內容值
        private void btnCancel_Click(object sender, EventArgs e)
        {
            textemail.Text = null;
            textlineid.Text = null;
        }

        //Forget查詢密碼
        private void btnForget_Click(object sender, EventArgs e)
        {
            DeliciousFoodEntities DeliciousFood = new DeliciousFoodEntities();

            try
            {                
                if (DeliciousFood.User.Any(u => u.UserEmail == textemail.Text && u.UserLineID == textlineid.Text))
                {
                    labelpassword.Text =(Convert.ToString(DeliciousFood.User.Where
                     (u => u.UserEmail == textemail.Text && u.UserLineID == textlineid.Text).Select(s => s.UserPassword).First()));
                }
                else
                {
                    MessageBox.Show($"請確認 {textemail.Text} 和 {textlineid.Text} 是否有誤");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
