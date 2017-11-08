using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IU.Ubicacion
{
    public partial class ubicacion : UserControl
    {
        public ubicacion()
        {
            InitializeComponent();
        }

        public bool ingreso()
        {
            BLL.ClassDireccion clsDireccion = new BLL.ClassDireccion();
            bool RESULTADO;
            if (BLL.ClassGeneral.tipo_operacion == "Nueva Ubicacion")
            {
                string ID = clsDireccion.nuevoid_DIRECCION("DIR");
                RESULTADO = clsDireccion.IngresoDirecion(ID, numericUpDown1.Value.ToString(), textEdit1.Text, textBox1.Text, departamento_municipio1.LONGITUD, departamento_municipio1.LATITUD, departamento_municipio1.ID_MUNI);
            }
            else
                RESULTADO = clsDireccion.Modificardirecion(numericUpDown1.Value.ToString(), textEdit1.Text, textBox1.Text, departamento_municipio1.LONGITUD, departamento_municipio1.LATITUD, departamento_municipio1.ID_MUNI);

            return RESULTADO;
        }

        public bool LISTO
        {
            get
            {
                bool listo;
                if (dxValidationProvider1.Validate())
                    if (textBox1.TextLength > 15)
                        if (departamento_municipio1.listo)
                            if (BLL.ClassGeneral.listo)
                                listo = true;
                            else
                                listo = false;
                        else
                            listo = false;
                    else
                        listo = false;
                else
                    listo = false;

                return listo;
            }
        }
        map.frm_mapaa mapi;


        private void ubicacion_Load(object sender, EventArgs e)
        {
            
        }


        public void llenar_datos()
        {
            if (BLL.ClassGeneral.tipo_operacion == "Nueva Ubicacion")
            {
                departamento_municipio1.llenar_datos("");
            }
            else
                departamento_municipio1.llenar_datos("Ver");
        }
        private void checkButton1_Click(object sender, EventArgs e)
        {
            if (departamento_municipio1.ddep_listo)
            {
                    BLL.ClassGeneral.latitud = departamento_municipio1.LATITUD;
                    BLL.ClassGeneral.longitud = departamento_municipio1.LONGITUD;
                    mapi = new map.frm_mapaa();

                    mapi.ShowDialog();
            }   
        }

    }
}
