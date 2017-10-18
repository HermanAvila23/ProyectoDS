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

//para el menu
using DevExpress.XtraBars.Docking2010;

namespace DS2017.Empresa
{
    public partial class frmEmpresa : DevExpress.XtraEditors.XtraForm
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresa.Representante.frmRepresentante nuevorepresentante = new Representante.frmRepresentante();
            nuevorepresentante.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Direccion.frmDireccion nuevadireccion = new Direccion.frmDireccion();
            nuevadireccion.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Representante.frmElegirRepresentante seleccionarrepresentante = new Representante.frmElegirRepresentante();
            seleccionarrepresentante.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Direccion.frmElegirDireccion seleccionardireccion = new Direccion.frmElegirDireccion();
            seleccionardireccion.ShowDialog();
        }







        //ejemplo para el menu
        //es un evento BottonClick
        //no el click
        private void windowsUIButtonPanel2_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "Guardar":

                   
                    break;
                case "Guardar y Salir":
                    
                    break;
                case "Limpiar":
                    
                    break;
                case "Salir":
                    this.Close();
                    break;
            }
        }
    }
}