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
        DeliciousFoodEntities DeliciousFood = new DeliciousFoodEntities();
        Recipes rp =new Recipes();
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

        #region 建立食譜
        //建立食譜
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var query = DeliciousFood.User.Where(d => d.UserEmail == textEmail.Text).Select(s => s.UserID).First();

            using (MemoryStream ms = new MemoryStream())
            using(Bitmap pic =new Bitmap(pBRecipe.Image))
            {
                //pic.Save(ms, ImageFormat.Jpeg);
                //rp.Photo = pic.ToString();
                pBRecipe.Image.Save(ms, ImageFormat.Jpeg);
                //rp.RecipeImage = ms.ToArray();
            }

            rp.UserID = query;
            rp.RecipeName = textFoodName.Text;
            rp.Introduction = textDescription.Text;
            rp.CookingTime = int.Parse(textCookingTime.Text);
            rp.Amount = int.Parse(textAmount.Text);

            DeliciousFood.Recipes.Add(rp);
            DeliciousFood.SaveChanges();
            MessageBox.Show("OK");
            
        }
        #endregion

        #region Return
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
        #endregion

        private void btnFindMd_Click(object sender, EventArgs e)
        {
            //if (!true)
            if (textEmailMdFind.Text =="" && textFdNameMdFdName.Text =="")
            {
                MessageBox.Show("請至少選擇任一種方法搜尋");
            }
            else if(textEmailMdFind.Text !="" && textFdNameMdFdName.Text !="" )
            {
                MessageBox.Show("一次只能用一種方式搜尋");
            }
            else if(textEmailMdFind.Text !="")
            {
                var query = from s in DeliciousFood.User
                            join c in DeliciousFood.Recipes on s.UserID equals c.UserID
                            where s.UserEmail == textEmailMdFind.Text
                            select new
                            {
                                  c.RecipeName,
                            };
                dataGridViewMd.DataSource = query.ToArray();
            }
            else if(textFdNameMdFdName.Text !="")
            {
                //dataGridViewMd.DataSource = dr.User.Where(s=>s.UserID ==rp.UserID).Select
            }
            
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            UserControlRecipeIngredientsText uc = new UserControlRecipeIngredientsText();
            uc.Size = new Size(150, 20);
            //uc.BorderStyle = BorderStyle.FixedSingle;
            fLPanelIngredients.Controls.Add(uc);
        }
    }
}
