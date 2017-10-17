using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DS2017.Direccion
{
    public partial class frmDireccion : DevExpress.XtraEditors.XtraForm
    {
        public frmDireccion()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCiudad nuevaCiudad = new frmCiudad();
            nuevaCiudad.ShowDialog();
        }
    }
}