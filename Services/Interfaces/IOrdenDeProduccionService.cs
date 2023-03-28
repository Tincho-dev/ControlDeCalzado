using Common;
using Model.Custom;
using Model.Domain.ControlDeCalzado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IOrdenDeProduccionService
    {
        IEnumerable<OrdenDeProduccionGrid> GetAll();
        OrdenDeProduccion Get(string id);
        void Create(OrdenDeProduccion model);
        void Update(OrdenDeProduccion model);
        void Delete(string id);
        OrdenDeProduccionGrid GetDetails(string id);
        bool JornadaActiva(string numero);
        void AgregarJornada(string Numero);
        void AgregarHorarioDeControl(string Numero);

        int HorarioActual(string numeroOp);
        HorarioDeControl ObtenerHorarioDeControl(string NumeroDeOrden);

        void GetJornadaActual(string id);
        void RegistrarIncidencia(int cantidad, int idHorarioDeControl);
        void RegistrarIncidencia(int cantidad, int idDefecto, Pie pie, int idHorarioDeControl);
        int TotalIncidenciasPrimera(string numero);
        int TotalIncidenciasPrimeraEnHorarioDeControl(int idHorarioDeControl);
        int TotalIncidenciasDefectoPorPie(int idHorarioDeControl, Pie pie, TipoDefecto tipoDefecto, int idDefecto);
        void CargarAlertas(string id);
        OrdenDeProduccion LineaOcupada(int linea);
        void UpdateCantidadDeParesDePrimera(string Numero, int cantidad);
        void IniciarOp(string Numero);
        void CambiarEstadoOrdenDeProduccion(string Numero, EstadoOp estadoOp);
        void TerminarOp(string Numero);
        void PausarOp(string Numero);

        OrdenDeProduccion GetOP(string user);
        IEnumerable<OrdenDeProduccion> GetOPSupervisor(string user);
        void AsignarSupervisorCalidad(string numero, string userid);
        void AsociarmeAOp(string numero);
        void DesvincularSupervisorDeCalidad(string numero);

    }
}
