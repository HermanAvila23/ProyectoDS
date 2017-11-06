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
        private vista_empelado_usuarioTableAdapter vista_emp_usu;

        private static string id_datos;
        private static string id_usuario;
        #endregion


        #region propiedades
        private vista_empelado_usuarioTableAdapter VISTA_EMP_USU
        {
            get
            {
                if (vista_emp_usu == null)
                    vista_emp_usu = new vista_empelado_usuarioTableAdapter();

                return vista_emp_usu;
            }
        }

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
                    tipo_usuario = new TIPO_USUARIOTableAdapter();

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
        #endregion

        #region generar id
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
        #endregion




        #region tablas

        #region Seleccionar
        //seleccion
        public DataTable seleccionarDatosUsuario()
        {
            /*
             * ID_DATOS_USUARIO
             * NOMBRE_EMPLEADO
             * APELLIDO_1_EMPLEADO 
             * APELLIDO_2_EMPLEADO 
             * DPI_EMPLEADO 
               TELEFONO_EMPLEADO
            */

            DataTable tabla = new DataTable();
            tabla = DATOS.GetDataBySeleccionarDatosUsuario(ID_DATOS);

            return tabla;
        }
        public DataTable seleccionarUsuario()
        {
            /*
             *ID_USUARIO
             *NOMBRE_USUARIO 
             *CONTRASEÑA 
             *ID_TIPO_USUARIO
             *ID_DATOS_USUARIO
             *ESTADO AS Estado
             */
            DataTable tabla = new DataTable();
            tabla = USUARIO.GetDataBySeleccionarUsuario(ID_USUARIO);

            return tabla;
        }

        #endregion



        #region listado
        //empleado y usuario
        public DataTable listaEmpleado_Usuario()
        {
            /*DATOS_USUARIO.NOMBRE_EMPLEADO + ' '+DATOS_USUARIO.APELLIDO_1_EMPLEADO +' '+ DATOS_USUARIO.APELLIDO_2_EMPLEADO as Empleado
             * USUARIO.NOMBRE_USUARIO as Usuario
             * USUARIO.ESTADO as Estado
             * TIPO_USUARIO.NOMBRE_TIPO_USUARIO as Tipo
             * DATOS_USUARIO.ID_DATOS_USUARIO as Id_datos
                USUARIO.ID_USUARIO as Id_Usuario
             */
            DataTable tabla = new DataTable();
            tabla = VISTA_EMP_USU.GetData();

            return tabla;
        }


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
        #endregion
        #endregion



        #region altas y modificaciones
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
        

        public bool InsertarUsuario(string id, string nombre, string contraseña, string tipo,bool estado)
        {
            bool resultado;
            try
            {
                
                USUARIO.INSERTAR_USUARIO(id, nombre, contraseña, tipo,ID_DATOS,estado);
                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }

        public bool ModificarUsuario(string nombre, string contraseña, string tipo, bool estado, bool tipo1)
        {
            bool resultado;
            try
            {
                if (tipo1)
                    USUARIO.MODIFICAR_USUARIO(ID_USUARIO, nombre, contraseña, tipo, ID_DATOS, estado);
                else
                    USUARIO.ModificarSimple(nombre, tipo,estado, ID_USUARIO);


                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }

        #endregion
















    }
        
}
