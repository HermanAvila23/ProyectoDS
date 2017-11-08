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
using DevExpress.XtraBars.Docking2010;

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
        }
        ClassUSUARIO clsUsuario = new ClassUSUARIO();
        bool resultado;
        string mensaje;
        private void FRM_USUARIO_Load(object sender, EventArgs e)
        {
            clsUsuario.ID_DATOS = BLL.ClassGeneral.USUARIO_DATOSID;
            clsUsuario.ID_USUARIO = BLL.ClassGeneral.USUARIO_ID;
            BLL.ClassGeneral.tipo_operacion = "Ver Usuario";
            usuario1.llenar_datos();
            datos_usuario_label1.llenar_datos();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            windowsUIButtonPanel1.Buttons[0].Properties.Visible = true;
            windowsUIButtonPanel1.Buttons[1].Properties.Visible = true;
            BLL.ClassGeneral.tipo_operacion = "Modificar Usuario";
            usuario1.llenar_datos();
            simpleButton1.Enabled = false;
            mensaje = "Modificado Exitosamente";
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
             string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "Guardar":
                    if(usuario1.LISTO)
                        resultado = usuario1.ingreso();
                    
                    if(resultado)
                    {alertControl1.Show(this, "Aviso", mensaje, Properties.Resources.Apply_32x32);
                    volver();
                    }
                    else
                    alertControl1.Show(this, "Aviso","Error Al Guardar", Properties.Resources.Cancel_32x32);

                    break;
                case "Cancelar":

                    volver();
                    break;
            }
    
        }
        protected void volver()
        {
            windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
            windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
            BLL.ClassGeneral.tipo_operacion = "Ver Usuario";
            usuario1.llenar_datos();
            simpleButton1.Enabled = true;
        }
        private void backstageViewTabItem1_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
        }
    }
}