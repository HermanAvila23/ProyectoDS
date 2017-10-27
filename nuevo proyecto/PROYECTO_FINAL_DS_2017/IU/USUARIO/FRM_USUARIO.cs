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
using BLL;

namespace IU.USUARIO
{
    public partial class FRM_USUARIO : DevExpress.XtraEditors.XtraForm
    {
        public FRM_USUARIO()
        {
            InitializeComponent();
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            panel8.Width = 381;
        }
        ClassUSUARIO AccesoUsuario = new ClassUSUARIO();
        private void FRM_USUARIO_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = AccesoUsuario.listarTipos();
            lookUpEdit1.Properties.DisplayMember = "Tipo";
            lookUpEdit1.Properties.ValueMember = "Id";

                DataTable tabla = new DataTable();
                //usuario 
                string id_datos = "";
                tabla = AccesoUsuario.seleccionarUsuario();
                foreach (DataRow f in tabla.Rows)
                {
                    textEdit6.Text = f[1].ToString();
                    textEdit7.Text = f[2].ToString();         
                    lookUpEdit1.EditValue = f[3].ToString();
                    id_datos = f[4].ToString();
                }
                //datos
                 tabla = new DataTable();
                 AccesoUsuario.ID_DATOS = id_datos;
                tabla = AccesoUsuario.seleccionarDatosUsuario();
                foreach (DataRow f in tabla.Rows)
                {
                    textEdit1.Text = f[1].ToString();
                    textEdit2.Text = f[2].ToString();
                    textEdit3.Text = f[3].ToString();
                    textEdit4.Text = f[4].ToString();
                    textEdit5.Text = f[5].ToString();
                }
        }

        protected void vista()
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}