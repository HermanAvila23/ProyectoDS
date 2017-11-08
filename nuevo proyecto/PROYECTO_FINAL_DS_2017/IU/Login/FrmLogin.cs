using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IU.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void slcTheme1_Click(object sender, EventArgs e)
        {

        }

        private void slCbtn1_Click(object sender, EventArgs e)
        {
            FRM_HOME frm = new FRM_HOME();
            frm.Show();
            this.Hide();
        }
    }
}
