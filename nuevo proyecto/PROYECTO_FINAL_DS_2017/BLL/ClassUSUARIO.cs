using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetUsuarioTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassUSUARIO
    {
        #region atributos
        private USUARIOTableAdapter usuario;
        private TIPO_USUARIOTableAdapter tipo_usuario;
        private DATOS_USUARIOTableAdapter datos;

        private static string id_datos;
        private static string id_usuario;
        #endregion


        //generar id
        public string nuevoid_datos(string prefijo)
        {
            string cuanto = DATOS.GENERAR_ID_DATOS_USUARIO(prefijo).ToString();
           prefijo = ClassGeneral.generarID(cuanto, prefijo);
           return prefijo;
        }

        public string nuevoid_usuario(string prefijo)
        {
            string cuanto = USUARIO.GENERAR_ID_USUARIO(prefijo).ToString();
            prefijo = ClassGeneral.generarID(cuanto, prefijo);
            return prefijo;
        }





        //tablas



        //seleccion
        public DataTable seleccionarDatosUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = DATOS.GetDataBySeleccionarDatosUsuario(ID_DATOS);

            return tabla;
        }
        public DataTable seleccionarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = USUARIO.GetDataBySeleccionarUsuario(ID_USUARIO);

            return tabla;
        }




        //listado

        //tipos
        public DataTable listarTipos()
        {
            DataTable tabla = new DataTable();
            tabla = TIPO.GetData_listarTipoUsuario();

            return tabla;
        }

        //listar todos los datos de los empleados
        public DataTable listarDatos()
        {
            DataTable tabla = new DataTable();
            tabla = DATOS.GetDataListarDatosUsuario();

            return tabla;
        }



        //altas y modificaciones
        #region
        public bool InsertarDatos(string id, string nombre, string apellido1, string apellido2, string dpi, string tel)
        {
            bool resultado;

            try
            {
                DATOS.INSERTAR_DATOS_USUARIO(id, nombre, apellido1, apellido2, dpi, tel);
                resultado = true; }
            catch
            { resultado = false; }
            return resultado;
        }

        public bool ModificarDatos(string nombre, string apellido1, string apellido2, string dpi, string tel)
        {
            bool resultado;

            try
            {
                DATOS.MODIFICAR_DATOS_USUARIO(ID_DATOS,nombre, apellido1, apellido2, dpi, tel);
                resultado = true;
            }
            catch
            { resultado = false; }
            return resultado;
        }
        

        public bool InsertarUsuario(string id, string nombre, string contraseña, string tipo, string dato)
        {
            bool resultado;
            try
            {
                USUARIO.INSERTAR_USUARIO(id, nombre, contraseña, tipo, dato);
                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }

        #endregion
















        //propiedades
        private USUARIOTableAdapter USUARIO
        {
            get 
            {
                if (usuario == null)
                    usuario = new USUARIOTableAdapter();

                return usuario;
            }
        }

        private TIPO_USUARIOTableAdapter TIPO
        {
            get
            {
                if (tipo_usuario == null)
                    tipo_usuario =new TIPO_USUARIOTableAdapter();

                return tipo_usuario;
            }
        }
        private DATOS_USUARIOTableAdapter DATOS
        {
            get
            {
                if (datos == null)
                    datos = new DATOS_USUARIOTableAdapter();

                return datos;
            }
        }

        //VARIABLES


        public string ID_USUARIO
        {
            get { return ClassUSUARIO.id_usuario; }
            set { ClassUSUARIO.id_usuario = value; }
        }

        public string ID_DATOS
        {
            get { return ClassUSUARIO.id_datos; }
            set { ClassUSUARIO.id_datos = value; }
        }
    }
}
