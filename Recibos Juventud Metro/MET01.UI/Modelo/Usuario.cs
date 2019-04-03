using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MET01.DO.DATA;
using MET01.UI.Clases;

namespace MET01.UI.Modelo
{
    public class Usuario
    {
        #region Metodos

        public Mensaje<List<MET01_USUARIO>> listarUsuariosActivos()
        {
            Mensaje<List<MET01_USUARIO>> result = new Mensaje<List<MET01_USUARIO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al obtener los usuarios";
            result.data = new List<MET01_USUARIO>();

            try
            {
                using (var db = new EntitiesMetro())
                {
                    var list = (from li in db.MET01_USUARIO.Where(l => l.ESTADO_REGISTRO == "A").OrderBy(l => l.USUARIO) select li).ToList();

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
                        result.mensaje = "No existen Usuarios Activos";
                        result.data = new List<MET01_USUARIO>();
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
