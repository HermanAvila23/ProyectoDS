using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
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
        bool error;
        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "Guardar":
                    if (dxValidationProvider1.Validate())
                    {
                        progressPanel1.Visible = true;
                        Validacion();
                        timer1.Enabled = true;
                    }
                    break;
                case "Cancelar":                 
                        limpiar();                                  
                    break;
            }
        }
        protected void Validacion()
        {
            string mensaje = " ";
            if (BLL.ClassGeneral.tipo_operacion == "Modificar Empleado")
            {
                mensaje = "Modificado Exitosamente";
                error = AccesoUsuario.ModificarDatos(textEdit1.Text, textEdit2.Text, textEdit3.Text, textEdit4.Text, textEdit5.Text);
            }
            else
            {
                mensaje = "Insertado Exitosamente";
                string nuevoid = AccesoUsuario.nuevoid_datos("EMP");
             error=   AccesoUsuario.InsertarDatos(nuevoid, textEdit1.Text, textEdit2.Text, textEdit3.Text, textEdit4.Text, textEdit5.Text);
            }

            if (error)
            {
                progressPanel1.Caption = mensaje;
                progressPanel1.Description = "Guardado";
            }
            else
            {
                progressPanel1.Caption = "Error";
                progressPanel1.Description = "Error al Guardar";
            }
        }
        protected void limpiar()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
        }
        private void Empleado_Load(object sender, EventArgs e)
        {
            if (BLL.ClassGeneral.tipo_operacion == "Nuevo Empleado_1")//para nuevo desde formularios
            {
                windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
                windowsUIButtonPanel1.Buttons[3].Properties.Visible = false;
            }
            else if (BLL.ClassGeneral.tipo_operacion == "Nuevo Empleado_2")//para los showdialog
            {
                windowsUIButtonPanel1.Buttons[2].Properties.Visible = false;
            }
            else
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
                if (BLL.ClassGeneral.tipo_operacion == "Modificar Empleado")
                {
                    windowsUIButtonPanel1.Buttons[2].Properties.Visible = false;
                    windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
                }
                else
                {
                    windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                    windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
                    windowsUIButtonPanel1.Buttons[2].Properties.Visible = false;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressPanel1.Visible = false;
            timer1.Enabled = false;
        }
    }
}
