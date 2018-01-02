using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms個人專題
{
    public partial class SearchForm : Form
    {
        
        public SearchForm()
        {
            InitializeComponent();        

        }

        //Logout登出
        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }


        DrEntities1 dr = new DrEntities1();
        User NwUser = new User();//資料表建立實體  

        //Search查詢=========================================================================
        private void btnFind_Click(object sender, EventArgs e)
        {           
            
            dataGridView1.DataSource = null;
            try
            {
                dataGridView1.DataSource = dr.User.Select(user => new
                {
                    
                    會員編號 = user.UserID,
                    Email = user.Email,
                    密碼 = user.PassWord,
                    性別 = user.Gender,
                    姓 = user.FirstName,
                    名 = user.LastName,
                    照片 = user.Photo,
                    LineID = user.LineID,

                }).ToList();                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //====================================================================================
        


        //Modify修改資料查詢===================================================================
        private void btnModifyFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            try
            {
                ModifydataGridView.DataSource = dr.User.Select(user => new
                {
                    會員編號 = user.UserID,
                    Email = user.Email,
                    密碼 = user.PassWord,
                    性別 = user.Gender,
                    姓 = user.FirstName,
                    名 = user.LastName,
                    照片 = user.Photo,
                    LineID = user.LineID,
                }).ToList();                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Modify修改圖片
        private void UserPhoto_Click(object sender, EventArgs e)
        {
            if (od.ShowDialog() == DialogResult.OK)
            {
                UserPhoto.Image = Image.FromStream(od.OpenFile());
            }
        }


        //Modify聯動查詢資料
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                byte[] g = (byte[])(ModifydataGridView.Rows[e.RowIndex].Cells["照片"].Value);
                textEmail.Text = Convert.ToString(ModifydataGridView.Rows[e.RowIndex].Cells["Email"].Value);
                textPassWord.Text = Convert.ToString(ModifydataGridView.Rows[e.RowIndex].Cells["密碼"].Value);
                textFirstName.Text = Convert.ToString(ModifydataGridView.Rows[e.RowIndex].Cells["姓"].Value);
                textLastName.Text = Convert.ToString(ModifydataGridView.Rows[e.RowIndex].Cells["名"].Value);
                textLineID.Text = Convert.ToString(ModifydataGridView.Rows[e.RowIndex].Cells["LineID"].Value);
                textGender.Text = Convert.ToString(ModifydataGridView.Rows[e.RowIndex].Cells["性別"].Value);

                using (MemoryStream ms = new MemoryStream(g))//圖片取出
                {
                    UserPhoto.Image = Image.FromStream(ms);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Modify修改上傳
        private void btnUpdata_Click(object sender, EventArgs e)
        {
            using (var ms = new MemoryStream())
            {
                UserPhoto.Image.Save(ms, ImageFormat.Jpeg);
                NwUser.Photo = ms.ToArray();
            }

            NwUser.Email = textEmail.Text;
            NwUser.PassWord = textPassWord.Text;
            NwUser.Gender = textGender.Text;
            NwUser.FirstName = textFirstName.Text;
            NwUser.LastName = textLastName.Text;
            NwUser.LineID = textLineID.Text;
            dr.Entry(NwUser).State = System.Data.Entity.EntityState.Modified;//修改記錄
            dr.SaveChanges();
            MessageBox.Show("ok");
            btnFind_Click(sender, e);
        }
        //Modify性別男
        private void radioMfMan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMan.Checked == true)
            {
                textGender.Text = "M";
            }
            else
            {
                textGender.Text = null;
            }
        }
        //Modify性別女
        private void radioMfFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFemale.Checked == true)
            {
                textGender.Text = "F";
            }
            else
            {
                textGender.Text = null;
            }
        }




        //Add&Delete加入圖片==========================================================
        OpenFileDialog od = new OpenFileDialog();
        private void Modify_Click(object sender, EventArgs e)
        {
            if (od.ShowDialog() == DialogResult.OK)
            {
                UserPhoto2.Image = Image.FromStream(od.OpenFile());
            }
        }
        //Add&Delete=================================================================

        //Add&Delete新增帳號資料
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var ms = new MemoryStream())
            {
                UserPhoto2.Image.Save(ms, ImageFormat.Jpeg);
                NwUser.Photo = ms.ToArray();
            }

            NwUser.Email = textEmail1.Text;
            NwUser.PassWord = textPassWord1.Text;
            NwUser.Gender = textGender1.Text;
            NwUser.FirstName = textFirstName.Text;
            NwUser.LastName = textLastName.Text;
            NwUser.LineID = textLineID1.Text;

            dr.User.Add(NwUser);
            dr.SaveChanges();
            MessageBox.Show("ok");
            btnFind_Click(sender, e);
        }

        //Add&Delete性別男
        private void radioMan_CheckedChanged(object sender, EventArgs e)
        {

            if (radioMan.Checked == true)
            {
                textGender1.Text = "M";
            }
            else
            {
                textGender1.Text = null;
            }
        }

        //Add&Delete性別女
        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFemale.Checked == true)
            {
                textGender1.Text = "F";
            }
            else
            {
                textGender1.Text = null;
            }
        }
        
        //==========================================================================
    }
}
