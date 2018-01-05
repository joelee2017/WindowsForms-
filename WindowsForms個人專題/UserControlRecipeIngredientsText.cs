using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms個人專題
{
    public partial class UserControlRecipeIngredientsText : UserControl
    {
        public UserControlRecipeIngredientsText()
        {
            InitializeComponent();
        }

        public string IngredientsName
        {
            get
            {
                return this.textBox1.Text;
            }
            set
            {
                this.textBox1.Text = value;
            }
        }
    }
}
