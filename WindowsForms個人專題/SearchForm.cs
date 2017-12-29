using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms個人專題
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }


        DrEntities1 dr = new DrEntities1();


        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
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

        OpenFileDialog od = new OpenFileDialog();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (od.ShowDialog() == DialogResult.OK)
            {
                UserPhoto2.Image = Image.FromStream(od.OpenFile());
            }
        }

    }
}
