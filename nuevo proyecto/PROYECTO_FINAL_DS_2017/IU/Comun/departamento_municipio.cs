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

namespace IU.Comun
{
    public partial class departamento_municipio : UserControl
    {
        public departamento_municipio()
        {
            InitializeComponent();
        }
        ClassComun clsComun = new ClassComun();
        DataTable tabladep;
        private string longitud;
        private string latitud;
        private string id_muni;
        private string id_depa;


        #region propiedades de variables
        public string ID_DEPA
        {
            get { return id_depa; }
            set { id_depa = value; }
        }

        public string ID_MUNI
        {
            get { return id_muni; }
            set { id_muni = value; }
        }

        public string LATITUD
        {
            get { return latitud; }
            set { latitud = value; }
        }

        public string LONGITUD
        {
            get { return longitud; }
            set { longitud = value; }
        }
        #endregion

        public bool listo
        {
            get
            {
                bool listo;
                if (lookUpEdit1.ItemIndex != -1)
                    if (lookUpEdit2.ItemIndex != -1)
                        listo = true;
                    else
                        listo = false;
                else
                    listo = false;

                return listo;
            }
        }

        public void llenar_datos(string tipo)
        {
            tabladep = new DataTable();
            tabladep = clsComun.Listar_departamento();
            lookUpEdit1.Properties.DataSource = tabladep;
            lookUpEdit1.Properties.DisplayMember = "Departamento";
            lookUpEdit1.Properties.ValueMember = "Id";

            if (tipo=="Ver")
            {
                DataTable tabla = new DataTable();
                tabla = clsComun.Seleccionar_municipio_departamento();
                string id="";
                foreach (DataRow item in tabla.Rows)
                {
                    id = item[0].ToString();
                }
                lookUpEdit1.EditValue = id;
            }
        }
        
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in tabladep.Rows)
            {
                if (lookUpEdit1.EditValue.ToString() == item[0].ToString())
                {                 
                    LONGITUD = item[2].ToString();
                    LATITUD = item[3].ToString();
                }
            }
            
            ID_DEPA = lookUpEdit1.EditValue.ToString();
            clsComun.ID_DEPARTAMENTO = ID_DEPA;
            lookUpEdit2.Properties.DataSource = clsComun.Listar_municipio();
            lookUpEdit2.Properties.DisplayMember = "Municipio";
            lookUpEdit2.Properties.ValueMember = "Id";
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            ID_MUNI= lookUpEdit2.EditValue.ToString();
        }

        private void departamento_municipio_Load(object sender, EventArgs e)
        {

        }
    }
}
