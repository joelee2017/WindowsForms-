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
            
            dataGridViewSearch.DataSource = null;
            try
            {
                dataGridViewSearch.DataSource = dr.User.Select(user => new
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
            dataGridViewSearch.DataSource = null;
            try
            {
                dataGridViewModify.DataSource = dr.User.Select(user => new
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

        //Modify聯動欄位資料顯示
        private void dataGridViewModify_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                byte[] g = (byte[])(dataGridViewModify.Rows[e.RowIndex].Cells["照片"].Value);
                textEmail.Text = Convert.ToString(dataGridViewModify.Rows[e.RowIndex].Cells["Email"].Value);
                textPassWord.Text = Convert.ToString(dataGridViewModify.Rows[e.RowIndex].Cells["密碼"].Value);
                textFirstName.Text = Convert.ToString(dataGridViewModify.Rows[e.RowIndex].Cells["姓"].Value);
                textLastName.Text = Convert.ToString(dataGridViewModify.Rows[e.RowIndex].Cells["名"].Value);
                textLineID.Text = Convert.ToString(dataGridViewModify.Rows[e.RowIndex].Cells["LineID"].Value);
                textGender.Text = Convert.ToString(dataGridViewModify.Rows[e.RowIndex].Cells["性別"].Value);
                labelNMfID.Text = Convert.ToString(dataGridViewModify.Rows[e.RowIndex].Cells["會員編號"].Value);

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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                User userUpdate = dr.User.Find(int.Parse(labelNMfID.Text));
                
                    userUpdate.Email = textEmail.Text;
                    userUpdate.PassWord = textPassWord.Text;
                    userUpdate.Gender = textGender.Text;
                    userUpdate.FirstName = textFirstName.Text;
                    userUpdate.LastName = textLastName.Text;
                    userUpdate.LineID = textLineID.Text;

                    using (var ms = new MemoryStream())
                    {
                        UserPhoto.Image.Save(ms, ImageFormat.Jpeg);
                        userUpdate.Photo = ms.ToArray();
                    }
                    dr.Entry(userUpdate).State = System.Data.Entity.EntityState.Modified;//修改記錄
                    dr.SaveChanges();

                    MessageBox.Show("ok");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Modify性別男
        private void radioMfMan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMfMan.Checked == true)
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
            if (radioMfFemale.Checked == true)
            {
                textGender.Text = "F";
            }
            else
            {
                textGender.Text = null;
            }
        }
        //===============================================================================

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

        //Add&Delete查詢
        private void btnADFind_Click(object sender, EventArgs e)
        {
            dataGridViewSearch.DataSource = null;
            try
            {
                dataGridViewAD.DataSource = dr.User.Select(user => new
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
                MessageBox.Show(ex.Message);
            }
        }

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
            NwUser.FirstName = textFirstName1.Text;
            NwUser.LastName = textLastName1.Text;
            NwUser.LineID = textLineID1.Text;

            dr.User.Add(NwUser);
            dr.SaveChanges();
            MessageBox.Show("ok");
            btnFind_Click(sender, e);
        }

        //Add&Delete性別男
        private void radioADMan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioADMan.Checked == true)
            {
                textGender1.Text = "M";
            }
            else
            {
                textGender1.Text = null;
            }
        }

        //Add&Delete性別女
        private void radioADFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioADFemale.Checked == true)
            {
                textGender1.Text = "F";
            }
            else
            {
                textGender1.Text = null;
            }
        }

        //Add&Delete清空欄位值
        private void btnADCanel_Click(object sender, EventArgs e)
        {
            textEmail1.Text = null;
            textPassWord1.Text = null;
            textGender1.Text = null;
            textFirstName1.Text = null;
            textLastName1.Text = null;
            textLineID1.Text = null;
            UserPhoto2.Image = null;
        }

        //Add&Delete聯動欄位資料顯示
        private void dataGridViewAD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                byte[] g = (byte[])(dataGridViewAD.Rows[e.RowIndex].Cells["照片"].Value);
                textEmail1.Text = Convert.ToString(dataGridViewAD.Rows[e.RowIndex].Cells["Email"].Value);
                textPassWord1.Text = Convert.ToString(dataGridViewAD.Rows[e.RowIndex].Cells["密碼"].Value);
                textFirstName1.Text = Convert.ToString(dataGridViewAD.Rows[e.RowIndex].Cells["姓"].Value);
                textLastName1.Text = Convert.ToString(dataGridViewAD.Rows[e.RowIndex].Cells["名"].Value);
                textLineID1.Text = Convert.ToString(dataGridViewAD.Rows[e.RowIndex].Cells["LineID"].Value);
                textGender1.Text = Convert.ToString(dataGridViewAD.Rows[e.RowIndex].Cells["性別"].Value);
                labelNADID.Text = Convert.ToString(dataGridViewAD.Rows[e.RowIndex].Cells["會員編號"].Value);

                using (MemoryStream ms = new MemoryStream(g))//圖片取出
                {
                    UserPhoto2.Image = Image.FromStream(ms);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Add&Delete刪除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定刪除嗎?", "刪除確認",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                User UserDelete = dr.User.Find(int.Parse(labelNADID.Text));
                if (UserDelete == null)
                {
                    MessageBox.Show($"無  {textEmail.Text}  記錄");
                }
                else
                {
                    dr.User.Remove(UserDelete);
                    dr.SaveChanges();
                    MessageBox.Show("刪除成功");
                    btnADFind_Click(sender, e);
                }
            }
        }
        
        //==========================================================================
    }
}
