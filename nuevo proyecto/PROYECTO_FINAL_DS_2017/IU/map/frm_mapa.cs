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
using DevExpress.XtraBars.Docking2010;
//para mapa
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace progra6_final.Ubicacion
{
    public partial class frm_mapa : DevExpress.XtraEditors.XtraForm
    {
        
            public frm_mapa()
        {
            InitializeComponent();
        }
            GMarkerGoogle marcador;
            GMapOverlay marcadorcapa;


            double latitud = 14.8515007;
            double longitud = -91.53146629999998;
            bool selec = false;
        private void frm_mapa_Load(object sender, EventArgs e)
        {
            latitud = BLL.ClassGeneral.latitud;

            longitud = BLL.ClassGeneral.longitud;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latitud, longitud);
            gMapControl1.MinZoom = 11;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 10;
            gMapControl1.AutoScroll = true;


            //marcador
            marcadorcapa = new GMapOverlay("Marcador");
            marcador = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.green);
            marcadorcapa.Markers.Add(marcador);

            marcador.ToolTipMode = MarkerTooltipMode.Always;  
            //datos del ususario

            
            if (BLL.ClassGeneral.listo)
            {
                gMapControl1.Overlays.Add(marcadorcapa);
                gMapControl1.Zoom = 18;         
                marcador.Position = new PointLatLng(latitud, longitud);
                selec = true;
            }
            
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (BLL.ClassGeneral.tipo_operacion != "Ver Ubicacion")
            {
                gMapControl1.Overlays.Add(marcadorcapa);
                // se obtiene los datos de lat y lng del mapa donde usuario presiono 
                latitud = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                longitud = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
                // Creamos el marcador para moverlo al lugar índicado
                marcador.Position = new PointLatLng(latitud, longitud);
                selec = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
        }

        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackZoom.Value;
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
             string tag = ((WindowsUIButton)e.Button).Tag.ToString();
             switch (tag)
             {
                 case "Seleccionar":
                     if (selec)
                     {
                         BLL.ClassGeneral.latitud = latitud;
                         BLL.ClassGeneral.longitud = longitud;
                         BLL.ClassGeneral.listo = true;
                         
                         //alertControl1.Show(this, "Aviso", "Ubicacion Marcada", Properties.
                         this.Close();                    
                     }
                     else
                     {
                        
                         //alertControl1.Show(this, "Aviso", "Debe Seleccionar la Ubicacion", Properties.Resources.Cancel_32x32);
                     }
                     break;
                 case "Cerrar":
                     this.Close();
                     break;
             }
        }

        private void gMapControl1_OnMapZoomChanged()
        {
            trackZoom.Value =Convert.ToInt32(gMapControl1.Zoom);
        }
    }
}