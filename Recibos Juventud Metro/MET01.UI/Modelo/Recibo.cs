using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MET01.DO.DATA;
using MET01.UI.Clases;

namespace MET01.UI.Modelo
{
    public class Recibo
    {
        #region Atributos Privados

        private MET01_RECIBO dbModel;        

        #endregion

        #region Propiedades

        public decimal reciboNumero
        {
            get { return dbModel.RECIBO; }
            set { dbModel.RECIBO = value; }
        }

        public string nombre
        {
            get { return dbModel.NOMBRE; }
            set { dbModel.NOMBRE = value; }
        }

        public Nullable<decimal> cantidad
        {
            get { return dbModel.TOTAL; }
            set { dbModel.TOTAL = value; }
        }

        public string cantidadLetras
        {
            get { return dbModel.TOTAL_LETRAS; }
            set { dbModel.TOTAL_LETRAS = value; }
        }

        public string conceptoRecibo
        {
            get { return dbModel.CONCEPTO; }
            set { dbModel.CONCEPTO = value; }
        }

        public Nullable<decimal> idEvento
        {
            get { return dbModel.EVENTO; }
            set { dbModel.EVENTO = value; }
        }

        public Nullable<decimal> idIglesia
        {
            get { return dbModel.IGLESIA; }
            set { dbModel.IGLESIA = value; }
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

        public decimal tipoRecibo { get; set; }
        public string recibo_oficina { get; set; }
        public decimal? recibo { get; set; }
        public string nombre_iglesia { get; set; }
        public string nombre_recibo { get; set; }
        public decimal? total { get; set; }
        public string usuario_gestion { get; set; }
        public string fecha_creacion { get; set; }
        public string total_letras { get; set; }
        public string concepto { get; set; }
        public string nombre_usuario { get; set; }

        #endregion

        #region Constructores

        public Recibo()
        {
            dbModel = new MET01_RECIBO();
        }

        public Recibo(MET01_RECIBO datos)
        {
            dbModel = datos;
        }

        #endregion

        #region Constantes

        private const string _sqlListadoRecibos = @"select
                                                    evento, recibo, recibo_oficina, nombre as nombre_iglesia, total, usuario_gestion, fecha_creacion
                                                    from(
                                                    select
                                                    reev.evento,
                                                    reev.recibo,
                                                    'Ofrenda en dia del Evento' recibo_oficina,
                                                    reev.nombre,
                                                    reev.total,
                                                    to_char(reev.fecha_creacion,'dd/mm/yyyy hh24:mi:ss') fecha_creacion,
                                                    us.nombre as usuario_gestion
                                                    from met01_recibo reev
                                                    inner join met01_iglesia igev
                                                    on reev.iglesia = igev.iglesia
                                                    inner join met01_usuario us
                                                    on reev.usuario_creacion = us.usuario
                                                    union all
                                                    select
                                                    reof.evento,
                                                    reof.recibo,
                                                    reof.recibo_oficina,
                                                    reof.nombre,
                                                    reof.total,
                                                    to_char(reof.fecha_creacion,'dd/mm/yyyy hh24:mi:ss') fecha_creacion,
                                                    us.nombre as usuario_gestion
                                                    from met01_recibo_oficina reof
                                                    inner join met01_iglesia igev
                                                    on reof.iglesia = igev.iglesia
                                                    inner join met01_usuario us
                                                    on reof.usuario_creacion = us.usuario)
                                                    where evento = :evento
                                                    order by recibo desc";

        private const string _sqlRecibo = @"select *
                                            from(
                                            select
                                            re.recibo,
                                            re.nombre nombre_recibo,
                                            re.total,
                                            re.total_letras,
                                            re.concepto,
                                            re.usuario_creacion usuario_gestion,
                                            us.nombre nombre_usuario,
                                            to_char(re.fecha_creacion,'dd/MM/YYYY') fecha_creacion
                                            from met01_recibo re, met01_usuario us
                                            where re.usuario_creacion = us.usuario
                                            union all
                                            select
                                            reof.recibo,
                                            reof.nombre nombre_recibo,
                                            reof.total,
                                            reof.total_letras,
                                            reof.concepto,
                                            reof.usuario_creacion usuario_gestion,
                                            us.nombre nombre_usuario,
                                            to_char(reof.fecha_creacion,'dd/MM/YYYY') fecha_creacion
                                            from met01_recibo_oficina reof, met01_usuario us
                                            where reof.usuario_creacion = us.usuario)
                                            where recibo = :recibo";

        #endregion

        #region Metodos

        public Mensaje<Recibo> registrarRecibo()
        {
            Mensaje<Recibo> result = new Mensaje<Recibo>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al tratar de registrar el recibo";
            result.data = new Recibo();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var correlativo = (from c in db.MET01_CORRELATIVO
                                       where c.CORRELATIVO == 1
                                       select c).SingleOrDefault();

                    MET01_RECIBO nuevoRecibo = new MET01_RECIBO();
                    nuevoRecibo.RECIBO = Convert.ToDecimal(correlativo.CORRELATIVO_ACTUAL);
                    nuevoRecibo.NOMBRE = this.nombre.ToUpper();
                    nuevoRecibo.TOTAL = this.cantidad;
                    nuevoRecibo.TOTAL_LETRAS = NumeroLetras.NumeroALetras(this.cantidad.ToString()).ToUpper();
                    nuevoRecibo.CONCEPTO = this.conceptoRecibo.ToUpper();
                    nuevoRecibo.EVENTO = Global.evento;
                    nuevoRecibo.IGLESIA = this.idIglesia;
                    nuevoRecibo.ESTADO_REGISTRO = "A";
                    nuevoRecibo.USUARIO_CREACION = Global.usuario;
                    nuevoRecibo.FECHA_CREACION = DateTime.Now;

                    db.MET01_RECIBO.Add(nuevoRecibo);
                    correlativo.CORRELATIVO_ACTUAL++;
                    db.SaveChanges();
                    result.mensaje = "Se registro el recibo Numero: " + nuevoRecibo.RECIBO + ",\nA nombre de: " + nuevoRecibo.NOMBRE + " de forma Exitosa...!!!";
                }
                result.codigo = 0;                
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }

        }

        public Mensaje<Recibo> obtenerCorrelativoVistaPrevia()
        {
            Mensaje<Recibo> result = new Mensaje<Recibo>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener el Correlativo";
            result.data = new Recibo();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var correlativo = (from c in db.MET01_CORRELATIVO
                                       where c.CORRELATIVO == 1
                                       select c).SingleOrDefault();

                    result.data.recibo = correlativo.CORRELATIVO_ACTUAL;
                }
                result.codigo = 0;
                result.mensaje = "Ok";
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }
        }

        public List<Recibo> datosRecibo()
        {
            List<Recibo> result = new List<Recibo>();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    StringBuilder sqlrecibo = new StringBuilder();
                    sqlrecibo.Append(_sqlRecibo);

                    var resp = db.Database.SqlQuery<Recibo>(sqlrecibo.ToString(), new object[]{this.recibo}).ToList<Recibo>();
                    result = resp;
                }
                return result;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Mensaje<List<Recibo>> listarRecibos()
        {
            Mensaje<List<Recibo>> result = new Mensaje<List<Recibo>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos";
            result.data = new List<Recibo>();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    StringBuilder sqllistar = new StringBuilder();
                    sqllistar.Append(_sqlListadoRecibos);

                    var resp = db.Database.SqlQuery<Recibo>(sqllistar.ToString(), new object[]{Global.evento}).ToList<Recibo>();

                    if (resp.Count == 0)
                    {
                        result.data = new List<Recibo>();
                    }
                    else
                    {
                        foreach (var item in resp)
                        {
                            result.data.Add(item);
                        }
                    }                    
                }
                result.codigo = 0;
                result.mensaje = "Ok";
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion al obtener el listado de Recibos, ref;" + ex.ToString();
                result.error = ex.ToString();
                return result;
            }
        }

        #endregion


    }
}
