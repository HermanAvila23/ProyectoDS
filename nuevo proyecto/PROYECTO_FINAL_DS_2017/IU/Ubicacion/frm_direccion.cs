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

namespace IU.Ubicacion
{
    public partial class frm_direccion : DevExpress.XtraEditors.XtraForm
    {
        public frm_direccion()
        {
            InitializeComponent();
        }
        string mensaje = "";
        private void frm_direccion_Load(object sender, EventArgs e)
        {
            if (BLL.ClassGeneral.tipo_operacion == "Nueva Ubicacion")
            {
                mensaje = "Ingresado Exitsamente";
                ubicacion1.llenar_datos();
            }
            else
            {
                if (BLL.ClassGeneral.tipo_operacion == "Modificar Ubicacion")
                {
                    windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
                    mensaje = "Modificado Exitosamente";
                }
                else
                {
                    windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                    windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
                }
            }
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "Guardar y Salir":
                    if (ubicacion1.LISTO)
                    {
                        if (ubicacion1.ingreso())
                        {
                            alertControl1.Show(this, "Aviso", mensaje, Properties.Resources.Apply_32x32);
                        }
                        else
                            alertControl1.Show(this, "Aviso", "Error Al Guardar", Properties.Resources.Cancel_32x32);
                        }
                    else
                    {
                        alertControl1.Show(this, "Aviso", "Faltan Campos Por Llenar", Properties.Resources.Cancel_32x32);
                    }
                    break;
                case "Limpiar":
                   
                    break;
                case "Cerrar":
                    this.Close();
                    break;
            }
        }
    }
}