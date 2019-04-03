using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MET01.UI.Clases;
using MET01.DO.DATA;

namespace MET01.UI.Modelo
{
    public class Reporte
    {
        #region Propiedades
                
        public decimal region { get; set; }
        public string nombre_iglesia { get; set; }
        public string nombre_pastor { get; set; }
        public string nombre_encargado { get; set; }
        public string telefono_encargado { get; set; }
        public Nullable<decimal> recibo_juventud { get; set; }
        public Nullable<decimal> total_recibo_juventud { get; set; }
        public string recibo_ofician_o_boleta { get; set; }
        public Nullable<decimal> total_recibo_oficina { get; set; }
        public string nombre_evento { get; set; }

        #endregion

        #region Constantes

        private const string _sqlreporte = @"select ev.nombre nombre_evento,
                                            infoiglesia.region,
                                            infoiglesia.nombre_iglesia,
                                            infoiglesia.nombre_pastor,
                                            infoiglesia.nombre_encargado,
                                            infoiglesia.telefono_encargado,
                                            inforecibo.recibo_juventud,
                                            nvl(inforecibo.total_recibo_juventud,0) total_recibo_juventud,
                                            decode(inforecibo.recibo_oficina,null,' ',inforecibo.recibo_oficina) recibo_ofician_o_boleta,
                                            nvl(inforecibo.total_recibo_oficina,0) total_recibo_oficina
                                            from(
                                            select
                                            ig.iglesia,
                                            ig.region,
                                            ig.nombre nombre_iglesia,
                                            pa.nombre nombre_pastor,
                                            en.nombre nombre_encargado,
                                            en.telefono telefono_encargado
                                            from met01_iglesia ig
                                            inner join met01_pastor pa
                                            on ig.pastor = pa.pastor
                                            inner join met01_encargado en
                                            on ig.encargado = en.encargado
                                            order by ig.region,ig.nombre) infoiglesia,
                                            (
                                            select rec.iglesia, rec.evento, 
                                            rec.recibo recibo_juventud, rof.recibo_oficina, 
                                            rev.total total_recibo_juventud, rof.total total_recibo_oficina
                                            from(
                                            select iglesia, evento, recibo from(
                                            select eev.iglesia, eev.evento, eev.recibo from met01_recibo eev
                                            where eev.estado_registro = 'A'
                                            union all
                                            select eof.iglesia, eof.evento, eof.recibo from met01_recibo_oficina eof
                                            where eof.estado_registro = 'A')
                                            where evento = :evento
                                            )rec, met01_recibo rev, met01_recibo_oficina rof
                                            where rec.evento = rev.evento(+)
                                            and rec.recibo = rev.recibo(+)
                                            and rec.evento = rof.evento(+)
                                            and rec.recibo = rof.recibo(+))inforecibo, met01_evento ev
                                            where infoiglesia.iglesia = inforecibo.iglesia(+)
                                            and ev.evento = :evento";

        #endregion

        #region Metodos Publicos

        public List<Reporte> infoReporte()
        {
            List<Reporte> result = new List<Reporte>();
            try
            {
                using (var db = new EntitiesMetro())
                {
                    StringBuilder sqlReporte = new StringBuilder();
                    sqlReporte.Append(_sqlreporte);

                    var list = db.Database.SqlQuery<Reporte>(sqlReporte.ToString(), new object[] { Global.evento }).ToList<Reporte>();

                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            result.Add(item);
                        }
                    }
                    else
                    {
                        result = new List<Reporte>();
                    }
                }
                return result;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #endregion

    }
}
