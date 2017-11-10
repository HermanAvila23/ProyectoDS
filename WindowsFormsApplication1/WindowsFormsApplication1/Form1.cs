using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShockwaveFlashObjects;
using System.Xml;
using AxShockwaveFlashObjects;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axShockwaveFlash1.LoadMovie(0, Application.StartupPath + "\\ds carro.swf");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void axShockwaveFlash1_FSCommand(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent e)
        {

               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablaParte = new DataTable();
            tablaParte.Columns.Add("Estado");
            axShockwaveFlash1.CallFunction("<invoke name=\"ope\"returntype=\"xml\"><arguments><string>"  + "Enviar" + "</string></arguments></invoke>");
            //axShockwaveFlash1.CallFunction("<invoke name=\"datos\" returntype=\"xml\"><arguments><string>" + "hola" + "</string></arguments></invoke>");           
        }
        DataTable tablaParte;
        private void axShockwaveFlash1_FlashCall(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FlashCallEvent e)
        {         
            XmlDocument DocumentoDatosR = new XmlDocument();
            DocumentoDatosR.LoadXml(e.request);

            XmlAttributeCollection Atributos = DocumentoDatosR.FirstChild.Attributes;
            String comando= Atributos.Item(0).InnerText;
           
            XmlNodeList lista = DocumentoDatosR.GetElementsByTagName("arguments");
            
            switch (comando)
            {
                case "operacion":

                      DataRow fila=tablaParte.NewRow();
                      fila[0]  = lista[0].InnerText;
                      tablaParte.Rows.Add(fila);
                      gridControl1.DataSource=tablaParte;
                    break;
            }     
        }
    }
}
