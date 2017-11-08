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
        }



        #region submenu empleado
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            
            //Seleccion de cliente
           BLL.ClassUSUARIO clsUsuario = new ClassUSUARIO();
           clsUsuario.ID_DATOS = gridView1.GetFocusedRowCellValue("Id").ToString();
           

            if (e.Button == MouseButtons.Right)
            {
                menu.Items.Add("Ver").Name = "Ver";
                menu.Items.Add("Modificar").Name = "Modificar";
                menu.Items.Add("Crear Usuario").Name = "Crear Usuario";
                
                menu.Show(gridControl1, new Point(e.X, e.Y));
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
            }
        }
        void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frm_c_empleado em = new frm_c_empleado();
            //throw new NotImplementedException();
            switch (e.ClickedItem.Name.ToString())
            {
                case "Ver":
                    BLL.ClassGeneral.tipo_operacion = "Ver Empleado";
                    em.ShowDialog();
                    break;
                case "Modificar":
                    BLL.ClassGeneral.tipo_operacion = "Modificar Empleado";
                    em.ShowDialog();
                    actualizar();
                    break;
                case "Crear Usuario":
                    USUARIO.frm_c_usuario us = new USUARIO.frm_c_usuario();
                    
                    BLL.ClassGeneral.tipo_operacion = "Nuevo Usuario";
                    us.ShowDialog();
                    break;

            }
        }
        #endregion



        private void frm_empleado_Load(object sender, EventArgs e)
        {
            
            actualizar();
            actualizar_usu();
        }
        protected void actualizar()
        {
            ClassUSUARIO AccesoUsuario = new ClassUSUARIO();

            gridControl1.DataSource = AccesoUsuario.listarDatos();
            gridView1.Columns["Id"].Visible = false;
        }
        protected void actualizar_usu()
        {
            ClassUSUARIO clsUsuario = new ClassUSUARIO();
            gridControl2.DataSource = clsUsuario.listaEmpleado_Usuario();
            gridView2.Columns["Id_datos"].Visible = false;
            gridView2.Columns["Id_Usuario"].Visible = false;
        }



        #region menu usuario
        
        
        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        ContextMenuStrip menu = new ContextMenuStrip();
            
         
           BLL.ClassUSUARIO clsUsuario = new ClassUSUARIO();
           clsUsuario.ID_DATOS = gridView2.GetFocusedRowCellValue("Id_datos").ToString();
           clsUsuario.ID_USUARIO = gridView2.GetFocusedRowCellValue("Id_Usuario").ToString();

            if (e.Button == MouseButtons.Right)
            {
                menu.Items.Add("Ver Usuario").Name = "Ver Usuario";
                menu.Items.Add("Ver Empleado").Name = "Ver Empleado";
                menu.Items.Add("Ver Historial").Name = "Ver Historial";
                menu.Items.Add("Modificar Usuario").Name = "Modificar";
                
                
                menu.Show(gridControl2, new Point(e.X, e.Y));
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_usuario);
            }
        }
        void menu_usuario(object sender, ToolStripItemClickedEventArgs e)
        {
            //throw new NotImplementedException();
            switch (e.ClickedItem.Name.ToString())
            {
                case "Ver Usuario":
                    USUARIO.frm_c_usuario us = new USUARIO.frm_c_usuario();
                    BLL.ClassGeneral.tipo_operacion = "Ver Usuario";
                    us.ShowDialog();
                    break;
                case "Ver Empleado":
                    frm_c_empleado emple = new frm_c_empleado();
                    BLL.ClassGeneral.tipo_operacion = "Ver Empleado";
                    emple.ShowDialog();
                    break;
                case "Modificar":
                    USUARIO.frm_c_usuario usu = new USUARIO.frm_c_usuario();
                    BLL.ClassGeneral.tipo_operacion = "Modificar Usuario";
                    usu.ShowDialog();
                    actualizar_usu();
                    break;
                case "Ver Historial":
                    break;
            }
        }
        #endregion





        private void backstageViewTabItem1_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            actualizar();
            label1.Text = "Empleados";
        }

        private void backstageViewTabItem2_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            label1.Text = "Usuarios";
            actualizar_usu();
        }

    }
}