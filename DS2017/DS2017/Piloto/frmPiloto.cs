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

namespace DS2017.Piloto
{
    public partial class frmPiloto : DevExpress.XtraEditors.XtraForm
    {
        public frmPiloto()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Direccion.frmDireccion nuevadireccion = new Direccion.frmDireccion();
            nuevadireccion.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Direccion.frmElegirDireccion seleccionardireccion = new Direccion.frmElegirDireccion();
            seleccionardireccion.ShowDialog();
        }
    }
}