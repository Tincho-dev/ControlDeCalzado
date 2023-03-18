using Common;
using Persistanse;
using System;
using System.Linq;

namespace Services
{
    public class IncidenciaService
    {
        public static int GetTotalIncidenciasOpDefectoPie(string NumeroOp, int IdDefecto, Pie pie)
        {
            var result = new int();
        

            using (var db = new ApplicationDbContext())
            {
                result = (from op in db.OrdenesDeProduccion.Where(o=>o.Numero == NumeroOp)
                          from j in db.JornadasLaborales.Where(j => j.Numero == NumeroOp).OrderByDescending(j => j.FechaInicioJornada)
                          from hdc in db.HorariosDeControl.Where(hd => hd.IdJornada == j.IdJornada).OrderByDescending(hd=>hd.HoraInicio)
                          from i in db.Incidencias.Where(
                                i => i.IdHorarioDeControl == hdc.IdHorarioDeControl 
                                && i.Pie == pie && i.IdDefecto == IdDefecto)
                          select i).Count();
            }
            return result;
        }

        public static int GetTotalIncidenciasOpDefectoPie(string numeroOp, object idDefecto, string pie)
        {
            throw new NotImplementedException();
        }

        public static void RegistrarIncidenciaOp(string numeroOp, int idDefecto, string pie)
        {
            throw new NotImplementedException();
        }
    
    }
}

