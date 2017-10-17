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

namespace DS2017.Empresa.Representante
{
    public partial class frmRepresentante : DevExpress.XtraEditors.XtraForm
    {
        public frmRepresentante()
        {
            InitializeComponent();
        }

        private void textEdit6_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }
    }
}