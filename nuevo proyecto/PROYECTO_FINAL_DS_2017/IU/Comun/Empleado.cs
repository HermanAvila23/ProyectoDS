using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace IU.Empleado
{
    public partial class Empleado : UserControl
    {
        public Empleado()
        {
            InitializeComponent();
        }
        ClassUSUARIO AccesoUsuario = new ClassUSUARIO();
        private bool estado;

        public bool ESTADO
        {
            get
            {
                if (dxValidationProvider1.Validate())
                    estado = true;
                else
                    estado = false;

                return estado;
            }
        }
        
        public bool ingreso()
        {
            bool error;
            if (BLL.ClassGeneral.tipo_operacion == "Modificar Empleado")
            {
                error = AccesoUsuario.ModificarDatos(textEdit1.Text, textEdit2.Text, textEdit3.Text, textEdit4.Text, textEdit5.Text);
            }
            else
            {
                string nuevoid = AccesoUsuario.nuevoid_datos("EMP");
             error=   AccesoUsuario.InsertarDatos(nuevoid, textEdit1.Text, textEdit2.Text, textEdit3.Text, textEdit4.Text, textEdit5.Text);
            }

            return error;
        }
        public void limpiar()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
        }
        private void Empleado_Load(object sender, EventArgs e)
        {
        }
        public void llenar_datos()
        {
            if (BLL.ClassGeneral.tipo_operacion != "Nuevo Empleado")
            {
                //datos
                //se debe de asignar valor a AccesoUsuario.ID_DATOS con el id del empleado             
                DataTable tabla = new DataTable();
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
        }
    }
}
