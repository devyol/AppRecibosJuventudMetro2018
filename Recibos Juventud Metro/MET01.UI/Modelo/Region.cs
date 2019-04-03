using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MET01.UI.Clases;
using MET01.DO.DATA;

namespace MET01.UI.Modelo
{
    public class Region
    {

        #region Atributos Privados

        private MET01_REGION dbModel;

        #endregion

        #region Propiedades Publicas

        public decimal region
        {
            get { return dbModel.REGION; }
            set { dbModel.REGION = value; }
        }

        public string nombre
        {
            get { return dbModel.NOMBRE; }
            set { dbModel.NOMBRE = value; }
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

        #region Constructor

        public Region()
        {
            dbModel = new MET01_REGION();
        }

        public Region(MET01_REGION datos)
        {
            dbModel = datos;
        }

        #endregion

        #region Metodos Publicos

        public Mensaje<List<Region>> listaRegiones()
        {
            Mensaje<List<Region>> result = new Mensaje<List<Region>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al obtener el listado de Regiones";
            result.data = new List<Region>();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var listaregiones = db.MET01_REGION.Where(r => r.REGION != 0).Select(r => r).OrderBy(r=>r.REGION).ToList();

                    if (listaregiones.Count > 0)
                    {
                        foreach (var item in listaregiones)
                        {
                            result.data.Add(new Region(item));
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen registros para el catalogo de Regiones";
                        result.data = new List<Region>();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";                    
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion al tratar de obtener el listado, ref: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }
        }

        #endregion
    }
}
