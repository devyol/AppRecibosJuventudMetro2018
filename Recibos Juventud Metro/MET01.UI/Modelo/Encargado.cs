using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MET01.UI.Clases;
using MET01.DO.DATA;

namespace MET01.UI.Modelo
{
    public class Encargado
    {
        #region Atributos Privados

        private MET01_ENCARGADO dbModel;

        #endregion

        #region Propiedades Publicas

        public decimal encargado
        {
            get { return dbModel.ENCARGADO; }
            set { dbModel.ENCARGADO = value; }
        }

        public string nombre
        {
            get { return dbModel.NOMBRE; }
            set { dbModel.NOMBRE = value; }
        }

        public string telefono
        {
            get { return dbModel.TELEFONO; }
            set { dbModel.TELEFONO = value; }
        }

        public string talla
        {
            get { return dbModel.TALLA; }
            set { dbModel.TALLA = value; }
        }

        public string estadoRegistro
        {
            get { return dbModel.ESTADO_REGISTRO; }
            set { dbModel.ESTADO_REGISTRO = value; }
        }

        public string usuarioCreacion
        {
            get { return dbModel.USUARIO_CREACION; }
            set { dbModel.USUARIO_CREACION = value; }
        }

        public string usuarioModificacion
        {
            get { return dbModel.USUARIO_MODIFICACION; }
            set { dbModel.USUARIO_MODIFICACION = value; }
        }

        public Nullable<DateTime> fechaCreacion
        {
            get { return dbModel.FECHA_CREACION; }
            set { dbModel.FECHA_CREACION = value; }
        }

        public Nullable<DateTime> fechaModificacion
        {
            get { return dbModel.FECHA_MODIFICACION; }
            set { dbModel.FECHA_MODIFICACION = value; }
        }

        #endregion

        #region Constructores

        public Encargado()
        {
            dbModel = new MET01_ENCARGADO();
        }

        public Encargado(MET01_ENCARGADO datos)
        {
            dbModel = datos;
        }

        #endregion

    }
}
