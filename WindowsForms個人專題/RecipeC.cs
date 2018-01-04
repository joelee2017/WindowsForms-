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
               pBRecipemd.Image = Image.FromFile(file);
            }
        }
        #endregion

        //建立食譜
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var query = dr.User.Where(d => d.Email == textEmailmd.Text).Select(s => s.UserID).First();

            using (MemoryStream ms = new MemoryStream())
            using(Bitmap pic =new Bitmap(pBRecipemd.Image))
            {
                pic.Save(ms, ImageFormat.Jpeg);
                rp.Photo = pic.ToString();
            }

            rp.UserID = query;
            rp.FoodName = textFoodNamemd.Text;
            rp.Description = textDescriptionmd.Text;
            rp.CookingTime_minute_ = int.Parse(textCookingTimemd.Text);
            rp.Amount = int.Parse(textAmountmd.Text);
            rp.Tips = textTipsmd.Text;

            dr.Recipe.Add(rp);
            dr.SaveChanges();
            MessageBox.Show("OK");
            
        }

        //Return返迴
        private void btnReturn_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.FormClosed += Sf_FormClosed;
            sf.Show(); this.Hide();
        }

        private void Sf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
