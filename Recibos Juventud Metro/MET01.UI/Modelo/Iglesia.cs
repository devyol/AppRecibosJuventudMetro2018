using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MET01.DO.DATA;
using MET01.UI.Clases;
using System.Windows.Forms;
using System.Transactions;

namespace MET01.UI.Modelo
{
    public class Iglesia
    {

        #region Atributos Privados

        private MET01_IGLESIA dbModel;        

        #endregion

        #region propiedades Publicas

        public decimal idIglesia
        {
            get { return dbModel.IGLESIA; }
            set { dbModel.IGLESIA = value; }
        }

        public string nombre
        {
            get { return dbModel.NOMBRE; }
            set { dbModel.NOMBRE = value; }
        }

        public Nullable<decimal> region
        {
            get { return dbModel.REGION; }
            set { dbModel.REGION = value; }
        }

        public Nullable<decimal> encargado
        {
            get { return dbModel.ENCARGADO; }
            set { dbModel.ENCARGADO = value; }
        }

        public Nullable<decimal> pastor
        {
            get { return dbModel.PASTOR; }
            set { dbModel.PASTOR = value; }
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

        public string nombre_encargado { get; set; }
        public string nombre_pastor { get; set; }
        public string telefono_encargado { get; set; }
        
        #endregion

        #region Constructores

        public Iglesia()
        {
            dbModel = new MET01_IGLESIA();
        }

        public Iglesia(MET01_IGLESIA datos)
        {
            dbModel = datos;
        }

        #endregion

        #region Constantes

        private const string _sqlIglesias = @"select
                                            ig.iglesia,
                                            ig.nombre nombre_iglesia,
                                            re.nombre nombre_region
                                            from
                                            met01_iglesia ig,
                                            met01_region re
                                            where ig.region = re.region 
                                            and upper(ig.nombre) like upper('%'||:parametro||'%')
                                            order by  ig.iglesia";

        private const string _sqlDatosIglesia = @"select
                                                ig.iglesia,
                                                re.nombre nombre_region,
                                                ig.nombre nombre_iglesia,
                                                en.nombre nombre_encargado,
                                                pa.nombre nombre_pastor 
                                                from
                                                met01_iglesia ig,
                                                met01_region re,
                                                met01_encargado en,
                                                met01_pastor pa
                                                where ig.region = re.region
                                                and ig.encargado = en.encargado
                                                and ig.pastor = pa.pastor
                                                and ig.iglesia = :iglesia";

        #endregion

        #region Metodos
        
        public Mensaje<Iglesia> datosiglesia()
        {
            Mensaje<Iglesia> result = new Mensaje<Iglesia>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al obtener datos de la iglesia";
            result.data = new Iglesia();

            try
            {
                using (var db = new EntitiesMetro())
                {                    
                    var dataIglesia = (from i in db.MET01_IGLESIA
                                       where i.IGLESIA == this.idIglesia
                                       select i).SingleOrDefault();

                    var datoPastor = (from p in db.MET01_PASTOR
                                      where p.PASTOR == dataIglesia.PASTOR
                                      select p).SingleOrDefault();

                    var datoEncargado = (from e in db.MET01_ENCARGADO
                                         where e.ENCARGADO == dataIglesia.ENCARGADO
                                         select e).SingleOrDefault();
                                        
                    this.nombre_pastor = datoPastor.NOMBRE.ToUpper();
                    this.nombre_encargado = datoEncargado.NOMBRE.ToUpper();
                    this.telefono_encargado = datoEncargado.TELEFONO;
                    dbModel = dataIglesia;

                }
                result.codigo = 0;
                result.mensaje = "Ok";
                result.data = this;
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion al tratar de Recuperar los datos, referencia: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }
        }

        public Mensaje<List<Iglesia>> llenarGridIglesias()
        {
            Mensaje<List<Iglesia>> result = new Mensaje<List<Iglesia>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al cargar el listado";
            result.data = new List<Iglesia>();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var listaIglesias = db.MET01_IGLESIA.Where(i => i.ESTADO_REGISTRO == "A").Select(i => i).OrderBy(i => i.NOMBRE).ToList();

                    if (listaIglesias.Count > 0)
                    {
                        foreach (var item in listaIglesias)
                        {
                            result.data.Add(new Iglesia(item));
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen Iglesias Registradas";
                        return result;
                    }
                }
                result.codigo = 0;
                result.mensaje = "OK";
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion al obtener el listado de Iglesias, ref: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }
        }

        public Mensaje<Iglesia> agregarNuevaIglesia()
        {
            Mensaje<Iglesia> result = new Mensaje<Iglesia>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al tratar de agregar la Iglesia";
            result.data = new Iglesia();

            try
            {
                using (var tr = new TransactionScope())
                {
                    using (var db = new EntitiesMetro())
                    {
                        var idp = db.MET01_PASTOR.Select(p => p.PASTOR).Max();
                        idp++;
                        MET01_PASTOR nuevoPastor = new MET01_PASTOR();
                        nuevoPastor.PASTOR = idp;
                        nuevoPastor.NOMBRE = this.nombre_pastor.ToUpper();
                        nuevoPastor.ESTADO_REGISTRO = "A";
                        nuevoPastor.USUARIO_CREACION = Global.usuario;
                        nuevoPastor.FECHA_CREACION = DateTime.Now;

                        db.MET01_PASTOR.Add(nuevoPastor);

                        int res_p = db.SaveChanges();

                        if (res_p <= 0)
                        {
                            Transaction.Current.Rollback();
                            result.codigo = -2;
                            result.mensaje = "No fue posible registrar la Iglesia, ref: No pudo registrar datos del Pastor";
                            result.data = new Iglesia();
                            return result;
                        }

                        var ide = db.MET01_ENCARGADO.Select(p => p.ENCARGADO).Max();
                        ide++;
                        MET01_ENCARGADO nuevoEncargado = new MET01_ENCARGADO();
                        nuevoEncargado.ENCARGADO = ide;
                        nuevoEncargado.NOMBRE = this.nombre_encargado.ToUpper();
                        nuevoEncargado.TELEFONO = this.telefono_encargado;
                        nuevoEncargado.ESTADO_REGISTRO = "A";
                        nuevoEncargado.USUARIO_CREACION = Global.usuario;
                        nuevoEncargado.FECHA_CREACION = DateTime.Now;

                        db.MET01_ENCARGADO.Add(nuevoEncargado);

                        int res_e = db.SaveChanges();

                        if (res_e <= 0)
                        {
                            Transaction.Current.Rollback();
                            result.codigo = -2;
                            result.mensaje = "No fue posible registrar la Iglesia ref: No pudo registrar datos del Encargado";
                            result.data = new Iglesia();
                            return result;
                        }

                        var idi = db.MET01_IGLESIA.Select(iga => iga.IGLESIA).Max();
                        idi++;
                        MET01_IGLESIA nuevaIglesia = new MET01_IGLESIA();
                        nuevaIglesia.IGLESIA = idi;
                        nuevaIglesia.NOMBRE = this.nombre.ToUpper();
                        nuevaIglesia.REGION = this.region;
                        nuevaIglesia.ENCARGADO = ide;
                        nuevaIglesia.PASTOR = idp;
                        nuevaIglesia.ESTADO_REGISTRO = "A";
                        nuevaIglesia.USUARIO_CREACION = Global.usuario;
                        nuevaIglesia.FECHA_CREACION = DateTime.Now;

                        db.MET01_IGLESIA.Add(nuevaIglesia);

                        int res_i = db.SaveChanges();

                        if (res_i <= 0)
                        {
                            Transaction.Current.Rollback();
                            result.codigo = -2;
                            result.mensaje = "No fue posible registrar la Iglesia, ref: No pudo registrar datos de la Iglesia";
                            result.data = new Iglesia();
                            return result;
                        }
                    }
                    tr.Complete();
                    result.codigo = 0;
                    result.mensaje = "Se registro la iglesia: " + this.nombre.ToUpper();
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion al guarda la Iglesia, ref: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }
        }

        public Mensaje<Iglesia> actualizarDatosIglesia()
        {
            Mensaje<Iglesia> result = new Mensaje<Iglesia>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al Actualizar Datos de la Iglesia";
            result.data = new Iglesia();

            try
            {
                using (var tr = new TransactionScope())
                {
                    using (var db = new EntitiesMetro())
                    {
                        var datoIglesia = (from i in db.MET01_IGLESIA
                                           where i.IGLESIA == this.idIglesia
                                           select i).SingleOrDefault();

                        var datoPastor = (from p in db.MET01_PASTOR
                                          where p.PASTOR == datoIglesia.PASTOR
                                          select p).SingleOrDefault();                        

                        var datoEncargado = (from e in db.MET01_ENCARGADO
                                             where e.ENCARGADO == datoIglesia.ENCARGADO
                                             select e).SingleOrDefault();                        

                        if (this.region != datoIglesia.REGION || this.nombre != datoIglesia.NOMBRE)
                        {
                            datoIglesia.REGION = this.region;
                            datoIglesia.NOMBRE = this.nombre.Trim().ToUpper();
                            datoIglesia.USUARIO_MODIFICACION = Global.usuario.ToUpper();
                            datoIglesia.FECHA_MODIFICACION = DateTime.Now;
                            int res_i = db.SaveChanges();

                            if (res_i <= 0)
                            {
                                Transaction.Current.Rollback();
                                result.codigo = -2;
                                result.mensaje = "No fue posible Actualizar la Region de la Iglesia";
                                return result;
                            }
                        }

                        if (this.nombre_pastor.Trim().ToUpper() != datoPastor.NOMBRE.Trim().ToUpper())
                        {
                            datoPastor.NOMBRE = this.nombre_pastor.Trim().ToUpper();
                            datoPastor.USUARIO_MODIFICACION = Global.usuario.ToUpper();
                            datoPastor.FECHA_MODIFICACION = DateTime.Now;
                            int res_p = db.SaveChanges();

                            if (res_p <= 0)
                            {
                                Transaction.Current.Rollback();
                                result.codigo = -2;
                                result.mensaje = "No fue posible Actualizar la Informacion del Pastor";
                                return result;                                
                            }
                        }

                        if (this.nombre_encargado.Trim().ToUpper() != datoEncargado.NOMBRE.Trim().ToUpper() ||
                                 this.telefono_encargado.Trim() != datoEncargado.TELEFONO.Trim())
                        {
                            datoEncargado.NOMBRE = this.nombre_encargado.Trim().ToUpper();
                            datoEncargado.TELEFONO = this.telefono_encargado;
                            datoEncargado.USUARIO_MODIFICACION = Global.usuario.ToUpper();
                            datoEncargado.FECHA_MODIFICACION = DateTime.Now;
                            int res_e = db.SaveChanges();

                            if (res_e <= 0)
                            {
                                Transaction.Current.Rollback();
                                result.codigo = -2;
                                result.mensaje = "No fue posible Actualizar la Informacion del Encargado";
                                return result;                                
                            }
                        }
                    }
                    tr.Complete();
                    result.codigo = 0;
                    result.mensaje = "Se Actualizaron los datos Correctamente";
                    return result;
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public Mensaje<List<Iglesia>> busquedaIglesia(string cadena)
        {
            Mensaje<List<Iglesia>> result = new Mensaje<List<Iglesia>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en Base de Datos al tratar de Obtener la busqueda";
            result.data = new List<Iglesia>();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var busqueda = db.MET01_IGLESIA.
                                   Where(b => b.NOMBRE.ToUpper().Contains(cadena.ToUpper())).
                                   Select(b => b).ToList();

                    if (busqueda.Count == 0)
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen datos para la consulta indicada";
                        result.data = new List<Iglesia>();
                        return result;
                    }
                    else
                    {
                        foreach (var item in busqueda)
                        {
                            result.data.Add(new Iglesia(item));
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
                result.mensaje = "Ocurrio una excepcion al momento de realizar la busqueda, ref: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }
        }

        #endregion
        
    }
}
