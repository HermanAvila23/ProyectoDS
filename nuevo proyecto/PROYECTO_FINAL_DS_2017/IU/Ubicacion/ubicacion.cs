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

        public bool LISTO
        {
            get
            {
                bool listo;
                if (dxValidationProvider1.Validate())
                    if (textBox1.TextLength > 15)
                        if (departamento_municipio1.listo)
                            listo = true;
                        else
                            listo = false;
                    else
                        listo = false;
                else
                    listo = false;

                return listo;
            }
        }

    }
}
