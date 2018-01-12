using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;



namespace WindowsForms個人專題
{
    public partial class SearchForm : Form
    {
        public string user { get; set; }
        //public static string user { get; set; }
        public SearchForm()
        {
            InitializeComponent();
                       

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            UserName.Text = user;
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogonForm lf3 = new LogonForm();
            lf3.FormClosed += Lf3_FormClosed;
            lf3.Show(); this.Hide();
        }

        private void Lf3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        private void btnRC_Click(object sender, EventArgs e)
        {
            RecipeC rc = new RecipeC();
            rc.FormClosed += Rc_FormClosed;
            rc.Show(); this.Hide();
        }

        private void Rc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            var userInfo = new UserInformation();

            var DeliciousFood = new DeliciousFoodEntities();
            
            DataGridViewFindUser.DataSource = null;

            DataGridViewFindUser.DataSource = userInfo.FinUser();

                for(int i=0; i < DataGridViewFindUser.Columns.Count; i++)
                if(DataGridViewFindUser.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)DataGridViewFindUser.Columns[i]).ImageLayout 
                                            = DataGridViewImageCellLayout.Stretch;
                        break;
                    }




        }

        private void DataGridViewSearchRecipe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var DeliciousFood = new DeliciousFoodEntities();

            var userInfo = new UserInformation();

            int userid = Convert.ToInt32(DataGridViewFindUser.Rows[e.RowIndex].Cells[0].Value);

            DataGridViewSearchRecipe.DataSource = userInfo.FindUserRecipe(userid);

            for (int i = 0; i < DataGridViewSearchRecipe.Columns.Count; i++)//調整DataGridView圖片顯示
                if (DataGridViewSearchRecipe.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)DataGridViewSearchRecipe.Columns[6]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }

        }
        //Search資料聯動 Recipe Picture
        private void dGridViewSearchRecipe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
                if (DataGridViewSearchRecipe.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    return;
                }
                else
                {
                byte[] g = (byte[])(DataGridViewSearchRecipe.Rows[e.RowIndex].Cells[6].Value);
                using (MemoryStream ms = new MemoryStream(g))//圖片取出
                {
                    pBSearch.Image = Image.FromStream(ms);
                }
            }
        }


        private void btnModifyFind_Click(object sender, EventArgs e)
        {
            var DeliciousFood = new DeliciousFoodEntities();

            DataGridViewFindUser.DataSource = null;
            try
            {
                dataGridViewModify.DataSource = DeliciousFood.User.Select(user => new
                {
                    編號 = user.UserID,
                    Email = user.UserEmail,
                    密碼 = user.UserPassword,
                    性別 = user.UserSex,
                    姓 = user.FirstName,
                    名 = user.LastName,
                    照片 = user.UserImage,
                    LineID = user.UserLineID,
                }).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void UserPhoto_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                UserPhoto.Image = Image.FromStream(open.OpenFile());
            }
        }
        
        private void dataGridViewModify_RowEnter(object sender, DataGridViewCellEventArgs e)
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
                labelNMfID.Text = Convert.ToString(dataGridViewModify.Rows[e.RowIndex].Cells["編號"].Value);

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
            var DeliciousFood = new DeliciousFoodEntities();

            try
            {
                SHA256 sHA256 = SHA256.Create();

                byte[] data = sHA256.ComputeHash(Encoding.UTF8.GetBytes(textPassWord.Text));

                string hashString = "";

                for (int i = 0; i < data.Length; i++)
                {
                    hashString += data[i].ToString("x2").ToUpperInvariant();
                }

                User userUpdate = DeliciousFood.User.Find(int.Parse(labelNMfID.Text));
                userUpdate.UserEmail = textEmail.Text;
                userUpdate.UserPassword = hashString;
                userUpdate.UserSex = textGender.Text;
                userUpdate.FirstName = textFirstName.Text;
                userUpdate.LastName = textLastName.Text;
                userUpdate.UserLineID = textLineID.Text;

                //picturebox無法直接儲存，所以需要另建一個bitmap包起來save
                using (MemoryStream ms = new MemoryStream())
                using (var pic = new Bitmap(UserPhoto.Image))
                {
                    //UserPhoto.Image = Image.FromStream(ms);
                    //byte[] imgdata = ms.GetBuffer();
                    pic.Save(ms, ImageFormat.Jpeg);

                }

                DeliciousFood.Entry(userUpdate).State = EntityState.Modified;//修改記錄
                DeliciousFood.SaveChanges();
                MessageBox.Show("ok");
                btnModifyFind_Click(sender, e);
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

    
        private void UserPhoto2_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                UserPhoto2.Image = Image.FromStream(open.OpenFile());
            }
        }



        private void btnADFind_Click(object sender, EventArgs e)
        {
            var DeliciousFood = new DeliciousFoodEntities();

            DataGridViewFindUser.DataSource = null;

            try
            {
                dataGridViewAD.DataSource = DeliciousFood.User.Select(user => new
                {
                    編號 = user.UserID,
                    Email = user.UserEmail,
                    密碼 = user.UserPassword,
                    性別 = user.UserSex,
                    姓 = user.FirstName,
                    名 = user.LastName,
                    照片 = user.UserImage,
                    LineID = user.UserLineID,
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
            var DeliciousFood = new DeliciousFoodEntities();

            var userinfo = new User();

            using (var ms = new MemoryStream())
            {
                UserPhoto2.Image.Save(ms, ImageFormat.Jpeg);
                userinfo.UserImage = ms.ToArray();
            }

            userinfo.UserEmail = textEmail1.Text;
            userinfo.UserPassword = textPassWord1.Text;
            userinfo.UserSex = textGender1.Text;
            userinfo.FirstName = textFirstName1.Text;
            userinfo.LastName = textLastName1.Text;
            userinfo.UserLineID = textLineID1.Text;
            userinfo.CreationDate = DateTime.Now;
            userinfo.ChangePassWorddate = DateTime.Now;

            DeliciousFood.User.Add(userinfo);
            DeliciousFood.SaveChanges();
            MessageBox.Show("ok");
            btnADFind_Click(sender, e);
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
        private void dataGridViewAD_RowEnter(object sender, DataGridViewCellEventArgs e)
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
                labelNADID.Text = Convert.ToString(dataGridViewAD.Rows[e.RowIndex].Cells["編號"].Value);

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
            var DeliciousFood = new DeliciousFoodEntities();

            if (MessageBox.Show("確定刪除嗎?", "刪除確認",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                User UserDelete = DeliciousFood.User.Find(int.Parse(labelNADID.Text));
                if (UserDelete == null)
                {
                    MessageBox.Show($"無  {textEmail.Text}  記錄");
                }
                else
                {
                    DeliciousFood.User.Remove(UserDelete);
                    DeliciousFood.SaveChanges();
                    MessageBox.Show("刪除成功");
                    btnADFind_Click(sender, e);
                }
            }
        }


    }
}
