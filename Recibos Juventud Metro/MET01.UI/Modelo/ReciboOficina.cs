using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MET01.UI.Clases;
using MET01.UI.Modelo;
using MET01.DO.DATA;

namespace MET01.UI.Modelo
{
    public class ReciboOficina
    {
        #region Atributos Privados

        private MET01_RECIBO_OFICINA dbModel;

        #endregion

        #region Propiedades

        public decimal reciboNumero
        {
            get { return dbModel.RECIBO; }
            set { dbModel.RECIBO = value; }
        }

        public string reciboOficina
        {
            get { return dbModel.RECIBO_OFICINA; }
            set { dbModel.RECIBO_OFICINA = value; }
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

        #endregion

        #region Constructores

        public ReciboOficina()
        {
            dbModel = new MET01_RECIBO_OFICINA();
        }

        public ReciboOficina(MET01_RECIBO_OFICINA datos)
        {
            dbModel = datos;
        }

        #endregion

        #region Metodos Publicos

        public Mensaje<ReciboOficina> registrarReciboOficina()
        {
            Mensaje<ReciboOficina> result = new Mensaje<ReciboOficina>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al tratar de registrar el recibo";
            result.data = new ReciboOficina();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    MET01_RECIBO_OFICINA nuevoRecibo = new MET01_RECIBO_OFICINA();

                    var correlativo = (from c in db.MET01_CORRELATIVO
                                       where c.CORRELATIVO == 1
                                       select c).Single();

                    nuevoRecibo.RECIBO = Convert.ToDecimal(correlativo.CORRELATIVO_ACTUAL);
                    nuevoRecibo.RECIBO_OFICINA = this.reciboOficina;
                    nuevoRecibo.NOMBRE = this.nombre.ToUpper();
                    nuevoRecibo.TOTAL = this.cantidad;
                    nuevoRecibo.TOTAL_LETRAS = NumeroLetras.NumeroALetras(this.cantidad.ToString()).ToUpper();
                    nuevoRecibo.CONCEPTO = this.conceptoRecibo.ToUpper();
                    nuevoRecibo.EVENTO = Global.evento;
                    nuevoRecibo.IGLESIA = this.idIglesia;
                    nuevoRecibo.ESTADO_REGISTRO = "A";
                    nuevoRecibo.USUARIO_CREACION = Global.usuario;
                    nuevoRecibo.FECHA_CREACION = DateTime.Now;

                    db.MET01_RECIBO_OFICINA.Add(nuevoRecibo);
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

        #endregion
    }
}
