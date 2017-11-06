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

namespace IU
{
    public partial class FRM_HOME : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FRM_HOME()
        {
            InitializeComponent();
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            USUARIO.FRM_USUARIO US = new USUARIO.FRM_USUARIO();
            US.MdiParent = this;
            US.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Empleado.frm_empleado emp = new Empleado.frm_empleado();
            emp.MdiParent = this;
            emp.Show();
        }
    }
}