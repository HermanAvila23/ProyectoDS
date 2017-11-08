using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IU.USUARIO
{
    public partial class Datos_usuario_label : UserControl
    {
        public Datos_usuario_label()
        {
            InitializeComponent();
        }

        /**
         * para que funcione se debe dar valor antes al ID_USUARIO
         * que esta en la classUsuario
         * Solo se puede hacer si esta instanciado 
         */


        BLL.ClassUSUARIO usuario = new BLL.ClassUSUARIO();
        private void Datos_usuario_label_Load(object sender, EventArgs e)
        {
        }
        public void llenar_datos()
        {
            DataTable tabla = new DataTable();
            tabla = usuario.seleccionarDatosUsuario();
            foreach (DataRow item in tabla.Rows)
            {
                labeln.Text = item[1].ToString();
                labela1.Text = item[2].ToString();
                labela2.Text = item[3].ToString();
            }
        }
    }
}
