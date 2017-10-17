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

namespace DS2017.Usuario
{
    public partial class frmUsuario : DevExpress.XtraEditors.XtraForm
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }
    }
}