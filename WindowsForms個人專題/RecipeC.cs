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
using System.Drawing.Imaging;

namespace WindowsForms個人專題
{
    public partial class RecipeC : Form
    {
        public RecipeC()
        {
            InitializeComponent();
        }
        FileDialog of1 = new OpenFileDialog();
        DrEntities1 dr = new DrEntities1();
        Recipe rp = new Recipe();
        User ur = new User();

        #region 打開圖片
        //打開圖片
        private void pBRecipe_Click(object sender, EventArgs e)
        {                      
            if (of1.ShowDialog() == DialogResult.OK)
            {
               string file = of1.FileName;
               pBRecipe.Image = Image.FromFile(file);
            }
        }
        #endregion

        //建立食譜
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var query = dr.User.Where(d => d.Email == textEmail.Text).Select(s => s.UserID).First();

            using (MemoryStream ms = new MemoryStream())
            using(Bitmap pic =new Bitmap(pBRecipe.Image))
            {
                pic.Save(ms, ImageFormat.Jpeg);
                rp.Photo = pic.ToString();
            }

            rp.UserID = query;
            rp.FoodName = textFoodName.Text;
            rp.Description = textDescription.Text;
            rp.CookingTime_minute_ = int.Parse(textCookingTime.Text);
            rp.Amount = int.Parse(textAmount.Text);
            rp.Tips = textTips.Text;

            dr.Recipe.Add(rp);
            dr.SaveChanges();
            MessageBox.Show("OK");
            
        }
    }
}
