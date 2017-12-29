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
    public partial class LogonForm : Form
    {
        public LogonForm()
        {
            InitializeComponent();
        }
        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateForm create = new CreateForm();
            create.ShowDialog();
        }
    }
}
