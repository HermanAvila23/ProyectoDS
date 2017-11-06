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

namespace IU.USUARIO
{
    public partial class frm_c_usuario : DevExpress.XtraEditors.XtraForm
    {
        public frm_c_usuario()
        {
            InitializeComponent();
        }
        string mensaje;
        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {           
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "Guardar":
                    if (usuario1.LISTO)
                    {
                        bool ingreso = usuario1.ingreso();

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
                    usuario1.limpiar();
                    break;
                case "Cerrar":
                    this.Close();
                    break;
            }
        }

        private void frm_c_usuario_Load(object sender, EventArgs e)
        {
            datos_usuario_label1.llenar_datos();
            llenar_datos();
        }
        public void llenar_datos()
        {
            if (BLL.ClassGeneral.tipo_operacion == "Nuevo Usuario")
                mensaje = "Ingresado Exitosamente";
            else
            {
                usuario1.llenar_datos();
                if (BLL.ClassGeneral.tipo_operacion == "Modificar Usuario")
                {
                    label1.Text = "Modificar Usuario";
                    mensaje = "Modificado Exitosamente";
                    this.Height = this.Height + 33;
                    usuario1.Height = usuario1.Height + 30;
                    windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
                }
                else
                {
                    label1.Text = "Usuario";
                    windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                    windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
                }
            }
        }
    }
}