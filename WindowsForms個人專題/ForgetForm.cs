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

        DrEntities1 dr = new DrEntities1();

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
            try
            {                
                if (dr.User.Any(u => u.Email == textemail.Text && u.LineID == textlineid.Text))
                {
                    labelpassword.Text =(Convert.ToString(dr.User.Where
                     (u => u.Email == textemail.Text && u.LineID == textlineid.Text).Select(s => s.PassWord).First()));
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
