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

namespace DS2017
{
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Empresa.frmListarEmpresa listaEmpresa = new Empresa.frmListarEmpresa();
            listaEmpresa.MdiParent = this;
            listaEmpresa.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Empresa.frmEmpresa nuevaEmpresa = new Empresa.frmEmpresa();
            nuevaEmpresa.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Empresa.frmElegirEmpresa modificarEmpresa = new Empresa.frmElegirEmpresa();
            modificarEmpresa.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Piloto.frmListarPiloto listarPiloto = new Piloto.frmListarPiloto();
            listarPiloto.MdiParent = this;
            listarPiloto.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Piloto.frmPiloto nuevopiloto = new Piloto.frmPiloto();
            nuevopiloto.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Piloto.frmElegirPiloto modificarpiloto = new Piloto.frmElegirPiloto();
            modificarpiloto.ShowDialog();
        }
    }
}