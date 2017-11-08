using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetComunTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassComun
    {
        #region atributos
        private DEPARTAMENTOTableAdapter departamento;
        private MUNICIPIOTableAdapter municipio;
        private vista_municipio_departamentoTableAdapter vista_municipio_departamento;

        private static string id_departamento;
        private static string id_municipio;

        

        #endregion

        #region propiedades
        private DEPARTAMENTOTableAdapter DEPARTAMENTO
        {
            get
            {
                if (departamento == null)
                    departamento = new DEPARTAMENTOTableAdapter();

                return departamento;
            }
        }
        private MUNICIPIOTableAdapter MUNICIPIO
        {
            get
            {
                if (municipio == null)
                    municipio = new MUNICIPIOTableAdapter();

                return municipio;
            }
        }
        private vista_municipio_departamentoTableAdapter VISTA_MUNICIPIO_DEPARTAMENTO
        {
            get
            {
                if (vista_municipio_departamento == null)
                    vista_municipio_departamento = new vista_municipio_departamentoTableAdapter();

                return vista_municipio_departamento;
            }
        }


        //variables generales
        public string ID_MUNICIPIO
        {
            get { return ClassComun.id_municipio; }
            set { ClassComun.id_municipio = value; }
        }

        public string ID_DEPARTAMENTO
        {
            get { return ClassComun.id_departamento; }
            set { ClassComun.id_departamento = value; }
        }
        #endregion

        #region Lista


        public DataTable Listar_departamento()
        {
            DataTable tabla = new DataTable();
            tabla= DEPARTAMENTO.GetData();

            return tabla;
        }

        public DataTable Listar_municipio()
        {
            DataTable tabla = new DataTable();
            tabla = MUNICIPIO.GetDataBylistarPordepar(ID_DEPARTAMENTO);

            return tabla;
        }



        //seleccion
        public DataTable Seleccionar_municipio_departamento()
        {
            DataTable tabla = new DataTable();
            tabla = VISTA_MUNICIPIO_DEPARTAMENTO.GetDataBySeleccionarMuni_depart(ID_MUNICIPIO);

            return tabla;
        }

        #endregion

    }
}
