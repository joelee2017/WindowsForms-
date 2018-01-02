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

        private void btnLogOut_Click(object sender, EventArgs e)//登出
        {

        }


        DrEntities1 dr = new DrEntities1();
        private void btnFind_Click(object sender, EventArgs e)//查詢
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //聯動尋查詢User食譜
            dataGridView5.DataSource = null;

            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        OpenFileDialog od = new OpenFileDialog();
        private void pictureBox2_Click(object sender, EventArgs e)//加入圖片
        {
            if (od.ShowDialog() == DialogResult.OK)
            {
                UserPhoto2.Image = Image.FromStream(od.OpenFile());
            }
        }

        User NwUser = new User();//資料表建立實體  
        private void btnAdd_Click(object sender, EventArgs e)//新增帳號資料
        {
            using (var ms = new MemoryStream())
            {
                UserPhoto2.Image.Save(ms, ImageFormat.Jpeg);
                NwUser.Photo = ms.ToArray();
            }

            NwUser.Email = Emailtext1.Text;
            NwUser.PassWord = PassWordtext1.Text;
            NwUser.Gender = Gendertext1.Text;
            NwUser.FirstName = FirstNametext.Text;
            NwUser.LastName = LastNametext.Text;
            NwUser.LineID = LineIDtext1.Text;

            dr.User.Add(NwUser);
            dr.SaveChanges();
            MessageBox.Show("ok");
        }

        private void radioMan_CheckedChanged(object sender, EventArgs e)//性別男
        {

            if (radioMan.Checked == true)
            {
                Gendertext1.Text = "M";
            }
            else
            {
                Gendertext1.Text = null;
            }
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)//性別女
        {
            if (radioFemale.Checked == true)
            {
                Gendertext1.Text = "F";
            }
            else
            {
                Gendertext1.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)//修改資料
        {
            dataGridView1.DataSource = null;
            try
            {
                dataGridView3.DataSource = dr.User.Select(user => new
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

        private void UserPhoto_Click(object sender, EventArgs e)//修改圖片
        {
            if (od.ShowDialog() == DialogResult.OK)
            {
                UserPhoto.Image = Image.FromStream(od.OpenFile());
            }
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            using (var ms = new MemoryStream())
            {
                UserPhoto.Image.Save(ms, ImageFormat.Jpeg);
                NwUser.Photo = ms.ToArray();
            }

            NwUser.Email = Emailtext.Text;
            NwUser.PassWord = PassWordtext.Text;
            NwUser.Gender = Gendertext.Text;
            NwUser.FirstName = FirstNametext.Text;
            NwUser.LastName = LastNametext.Text;
            NwUser.LineID = LineIDtext.Text;

            dr.Entry(NwUser).State=
            dr.SaveChanges();
            MessageBox.Show("ok");
        }
    }
}
