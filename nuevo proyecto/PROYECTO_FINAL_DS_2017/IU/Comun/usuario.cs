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
    public partial class usuario : UserControl
    {
        public usuario()
        {
            InitializeComponent();
        }
        string temcontra = "";

        bool tipo=false;
        private static bool listo;
        public void limpiar()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
        }
        public bool LISTO
        {
            get { 
                if ((dxValidationProvider1.Validate()) && (lookUpEdit1.ItemIndex != -1))
                listo=true;
                else
                listo=false;
 
                return listo; }
        }

        public bool ingreso()
        {
            bool listo1;
            if (BLL.ClassGeneral.tipo_operacion == "Nuevo Usuario")
            {
                string newid = USU.nuevoid_usuario("USU");

                listo1 = USU.InsertarUsuario(newid, textEdit1.Text, textEdit2.Text, lookUpEdit1.EditValue.ToString(), true);
            }
            else
            {
                listo1 = USU.ModificarUsuario(textEdit1.Text, textEdit2.Text, lookUpEdit1.EditValue.ToString(), checkBox1.Checked, tipo);

            }

            return listo1;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (simpleButton1.Text == "Cambiar Contraseña")
            {
                temcontra = textEdit2.Text;
                textEdit2.Text = "";
                textEdit3.Text = "";
                simpleButton1.Text = "Cancelar";
                textEdit2.Enabled = true;
                textEdit3.Enabled = true;
                tipo = true;
            }
            else
            {
                simpleButton1.Text = "Cambiar Contraseña";
                textEdit2.Text = temcontra;
                textEdit3.Text = temcontra;
                textEdit2.Enabled = false;
                textEdit3.Enabled = false;
                tipo = false;
            }

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }
        BLL.ClassUSUARIO USU = new BLL.ClassUSUARIO();

        private void usuario_Load(object sender, EventArgs e)
        {
            //llenar 
              lookUpEdit1.Properties.DataSource = USU.listarTipos();
            lookUpEdit1.Properties.DisplayMember = "Tipo";
            lookUpEdit1.Properties.ValueMember = "Id";

            llenar_datos();

        }
        public void llenar_datos()
        {
            //tipo de operacion
            if (BLL.ClassGeneral.tipo_operacion != "Nuevo Usuario")
            {
                //recuperar datos
                DataTable tabla = new DataTable();
                tabla = USU.seleccionarUsuario();

                foreach (DataRow item in tabla.Rows)
                {
                    textEdit1.Text = item[1].ToString();
                    textEdit2.Text = item[2].ToString();
                    lookUpEdit1.EditValue = item[3].ToString();
                    checkBox1.Checked = Convert.ToBoolean(item[5].ToString());
                }
                textEdit3.Text = textEdit2.Text;
                if (BLL.ClassGeneral.tipo_operacion == "Modificar Usuario")
                {
                    simpleButton1.Visible = true;
                    textEdit2.Enabled = false;
                    textEdit3.Enabled = false;
                }
                else
                {
                    textEdit2.Enabled = false;
                    textEdit3.Enabled = false;
                    simpleButton1.Visible = false;
                }

                checkBox1.Enabled = true;
            }
        }
    }
}
