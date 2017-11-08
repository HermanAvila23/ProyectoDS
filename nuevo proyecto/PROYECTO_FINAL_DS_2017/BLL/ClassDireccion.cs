using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetUbicacionTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassDireccion
    {
        private DIRECCIONTableAdapter direccion;
        private static string id_direccion;

        public string ID_DIRECCION
        {
            get { return ClassDireccion.id_direccion; }
            set { ClassDireccion.id_direccion = value; }
        }

        private DIRECCIONTableAdapter DIRECCION
        {
            get
            {
                if(direccion==null)
                    direccion=new DIRECCIONTableAdapter();

                return direccion;
            }
        }



        public string nuevoid_DIRECCION(string prefijo)
        {
            string cuanto = DIRECCION.PGI_DIRECCION(prefijo).ToString();
            prefijo = ClassGeneral.generarID(cuanto, prefijo);
            return prefijo;
        }
        #region altas, modificaciones

        public bool IngresoDirecion(string id,string zona,string calle,string descri,double longitud,double latitud,string id_muni)
        {
            bool resultado;
                try
                {
                    DIRECCION.PI_Direccion(id, zona, calle, descri, longitud, latitud, id_muni);
                    resultado=true;
                }
            catch
                {resultado=false;}
            return resultado;
        }
        public bool Modificardirecion(string zona, string calle, string descri, double longitud, double latitud, string id_muni)
        {
            bool resultado;
            try
            {
                DIRECCION.PM_Direccion(zona, calle, descri, longitud, latitud, id_muni, ID_DIRECCION);
                resultado = true;
            }
            catch
            { resultado = false; }
            return resultado;
        }
        #endregion




        #region listas
        public DataTable SeleccionarDireccion(string Id_direccion)
        {
            DataTable tabla = new DataTable();
            tabla = DIRECCION.GetDataBySeleccionarDireccioon(Id_direccion);

            return tabla;
        }
        #endregion
    }
}
