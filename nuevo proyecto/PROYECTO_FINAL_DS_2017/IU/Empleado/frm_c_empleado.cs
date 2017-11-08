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
using DevExpress.XtraBars.Docking2010;

namespace IU.Empleado
{
    public partial class frm_c_empleado : DevExpress.XtraEditors.XtraForm
    {
        public frm_c_empleado()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "Guardar":
                    if (empleado1.ESTADO)
                    {
                        bool ingreso = empleado1.ingreso();

                        if (ingreso)
                        {
                            alertControl1.Show(this, "Aviso", mensaje, Properties.Resources.Apply_32x32);
                            empleado1.limpiar();
                        }
                        else
                            alertControl1.Show(this, "Aviso", "Error Al Guardar", Properties.Resources.Cancel_32x32);
                    }
                    break;
                case "Guardar y Salir":
                    if (empleado1.ESTADO)
                    {
                        bool ingreso = empleado1.ingreso();

                        if (ingreso)
                        {
                            alertControl1.Show(this, "Aviso", mensaje, Properties.Resources.Apply_32x32);
                            this.Close();
                        }
                        else
                            alertControl1.Show(this, "Aviso", "Error Al Guardar", Properties.Resources.Cancel_32x32);
                    }
                    break;
                case "Limpiar":
                    empleado1.limpiar();
                    break;
                case "Cerrar":
                    this.Close();
                    break;
            }
        }
        string mensaje;
        protected void llenar()
        {
            if (BLL.ClassGeneral.tipo_operacion == "Nuevo Empleado")
                mensaje = "Ingresado Exitosamente";
            else
            {
                empleado1.llenar_datos();
                if (BLL.ClassGeneral.tipo_operacion == "Modificar Empleado")
                {
                    label1.Text = "Modificar Empleado";
                    mensaje = "Modificado Exitosamente";
                    windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                    windowsUIButtonPanel1.Buttons[2].Properties.Visible = false;
                }
                else
                {
                    label1.Text = "Empleado";
                    windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                    windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
                    windowsUIButtonPanel1.Buttons[2].Properties.Visible = false;
                }
            }
        }

        private void frm_c_empleado_Load(object sender, EventArgs e)
        {
            llenar();
        }
    }
}