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

        #endregion


    }
}
