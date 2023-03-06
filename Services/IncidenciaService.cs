using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class IncidenciaService
    {
        public static int GetTotalIncidenciasOpDefectoPie(string NumeroOp, string IdDefecto, string pie)()
        {
            var result = new int();

            using (var db = new ApplicationDbContext())
            {
                result = (from op in db.OrdenesDeProduccion.Where(o=>o.Numero == NumeroOp)
                          from j in db.Jornadas.Where(j=>j.Numero == NumeroOp).OrderByDescending(j=>j.FechaInicio).First()
                          from hdc in db.HorariosDeControl.Where(hd => hd.IdJornada == j.IdJornada).OrderByDescending(hd=>hd.FechaInicio).First()
                          from i in db.Incidencias.Where(
                                i => i.IdHoraioDeControl == hdc.IdHorarioDeControl 
                                && i.Pie == pie && i.IdDefecto == IdDefecto)
                          select i).Count();
            }
            return result;
        }


    }
}
