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

namespace IU.Empleado
{
    public partial class frm_empleado : DevExpress.XtraEditors.XtraForm
    {
        public frm_empleado()
        {
            InitializeComponent();
            BLL.ClassGeneral.tipo_operacion = "Nuevo Empleado_1";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void frm_empleado_Load(object sender, EventArgs e)
        {
            actualizar();
        }
        protected void actualizar()
        {
            ClassUSUARIO AccesoUsuario = new ClassUSUARIO();

            gridControl1.DataSource = AccesoUsuario.listarDatos();
            gridView1.Columns["Id"].Visible = false;
        }
        private void backstageViewTabItem1_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            actualizar();
        }
    }
}