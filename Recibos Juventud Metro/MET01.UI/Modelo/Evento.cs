using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MET01.UI.Clases;
using MET01.DO.DATA;

namespace MET01.UI.Modelo
{
    public class Evento
    {

        #region Metodos

        public Mensaje<List<MET01_EVENTO>> listarEventosActivos()
        {
            Mensaje<List<MET01_EVENTO>> result = new Mensaje<List<MET01_EVENTO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en Base de Datos al obtener el listado de Eventos";
            result.data = new List<MET01_EVENTO>();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var list = (from li in db.MET01_EVENTO.Where(l => l.ESTADO_REGISTRO == "A").OrderByDescending(l => l.EVENTO) select li).ToList();

                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            result.data.Add(item);
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen Eventos Activos";
                        result.data = new List<MET01_EVENTO>();
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
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }

        }

        public Mensaje<List<MET01_EVENTO>> listarTodoseEventos()
        {
            Mensaje<List<MET01_EVENTO>> result = new Mensaje<List<MET01_EVENTO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Eventos";
            result.data = new List<MET01_EVENTO>();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var list = (from li in db.MET01_EVENTO.OrderByDescending(a => a.EVENTO) select li).ToList();

                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            result.data.Add(item);
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen Eventos Registrados que mostrar, ir al Mantenimiento de Bancos";
                        result.data = new List<MET01_EVENTO>();
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
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }

        }

        public Mensaje<MET01_EVENTO> obtenerEvento(MET01_EVENTO ev)
        {
            Mensaje<MET01_EVENTO> result = new Mensaje<MET01_EVENTO>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener el Evento";
            result.data = new MET01_EVENTO();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var concep = (from li in db.MET01_EVENTO
                                  where li.EVENTO == ev.EVENTO
                                  select li).SingleOrDefault();

                    if (concep != null)
                    {
                        result.data = concep;
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe informacion del Evento enviado";
                        result.data = new MET01_EVENTO();
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
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }

        }

        public Mensaje<List<MET01_ESTADO>> listaDescripcionEstado()
        {
            Mensaje<List<MET01_ESTADO>> result = new Mensaje<List<MET01_ESTADO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Estados";
            result.data = new List<MET01_ESTADO>();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var list = (from es in db.MET01_ESTADO.Where(d => d.ESTADO == "A" || d.ESTADO == "B").OrderBy(e => e.ESTADO) select es).ToList();

                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            result.data.Add(item);
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen Estados Registrados que mostrar";
                        result.data = new List<MET01_ESTADO>();
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
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }
        }

        public Mensaje<Evento> RegistrarEvento(MET01_EVENTO ev)
        {
            Mensaje<Evento> result = new Mensaje<Evento>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de registrar el Evento";
            result.data = new Evento();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var valcorrelativo = (from li in db.MET01_EVENTO select li.EVENTO).ToList();
                    decimal correlativo = 0;

                    if (valcorrelativo.Count > 0)
                    {
                        correlativo = valcorrelativo.Max() + 1;
                    }
                    else
                    {
                        correlativo = 1;
                    }

                    MET01_EVENTO nuevoEvento = new MET01_EVENTO()
                    {
                        EVENTO = correlativo,
                        NOMBRE = ev.NOMBRE,
                        ESTADO_REGISTRO = ev.ESTADO_REGISTRO,
                        //USUARIO_CREACION = Global.usuario,
                        USUARIO_CREACION = "MET01",
                        FECHA_CREACION = DateTime.Now
                    };

                    db.MET01_EVENTO.Add(nuevoEvento);
                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se ha registrado correctamente el Evento: " + ev.NOMBRE;
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion, Referencia: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }

        }

        public Mensaje<Evento> ActualizarRegistroEvento(MET01_EVENTO ev)
        {
            Mensaje<Evento> result = new Mensaje<Evento>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al Actualizar el registro del Evento " + ev.NOMBRE;
            result.data = new Evento();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    MET01_EVENTO nuevoEvento = (from e in db.MET01_EVENTO
                                                where e.EVENTO == ev.EVENTO
                                                select e).SingleOrDefault();

                    if (nuevoEvento == null)
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe ningun registro con el dato del evento enviando para su Actualizacion";
                        return result;
                    }

                    nuevoEvento.NOMBRE = ev.NOMBRE;
                    nuevoEvento.ESTADO_REGISTRO = ev.ESTADO_REGISTRO;
                    //nuevoEvento.USUARIO_MODIFICACION = Global.usuariologueado;
                    nuevoEvento.USUARIO_MODIFICACION = "MET01";
                    nuevoEvento.FECHA_MODIFICACION = DateTime.Now;
                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se ha actualizado correctamente el Evento: " + ev.NOMBRE;
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion, Referencia: " + ex.ToString();
                result.error = ex.ToString();
                return result;
            }

        }

        #endregion


    }
}
