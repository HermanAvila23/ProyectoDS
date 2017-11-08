using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
   public class ClassGeneral
    {
       //que tipo de operacion se realizara
       public static string tipo_operacion = "";


       //datos del usuario
       private static string usuario_id="USU-0001";
       private static string usuario_tipo="Administrador";
       private static string usuario_datosId="EMP-0001";



       //mapa punto
       public static double latitud;
       public static double longitud;
       public static bool listo;

       #region control
       //control para usuario
       
       #endregion

       #region propiedades
       public static string USUARIO_DATOSID
       {
           get { return ClassGeneral.usuario_datosId; }
           set { ClassGeneral.usuario_datosId = value; }
       }

       public static string USUARIO_ID
       {
           get { return ClassGeneral.usuario_id; }
           set { ClassGeneral.usuario_id = value; }
       }
       

       public static string USUARIO_TIPO
       {
           get { return ClassGeneral.usuario_tipo; }
           set { ClassGeneral.usuario_tipo = value; }
       }
       #endregion


       //para agregar el correlativo al nuevo id
       public static string generarID(string correlativo,string prefijo)
       {
           string newid = prefijo;
           correlativo = (Convert.ToInt16(correlativo) + 1).ToString();

           if (Convert.ToInt16(correlativo) < 9)
               newid = newid + "-000" + correlativo;
           else
               if (Convert.ToInt16(correlativo) < 99)
                   newid = newid + "-00" + correlativo;
               else
                   if (Convert.ToInt16(correlativo) < 999)
                       newid = newid + "-0" + correlativo;
                   else
                       newid = newid + "-" + correlativo;
           return newid;
       }
       
    }
}
