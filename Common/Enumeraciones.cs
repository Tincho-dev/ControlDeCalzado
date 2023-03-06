using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum EstadoOp
    {
        Pausada,
        Iniciada,
        Finalizada
    }

    public enum Pie
    {
        Izquierdo,
        Derecho
    }

    public enum TipoDefecto
    {
        [Description("Observado ")]
        Observado = 1,
        [Description("Reproceso ")]
        Reproceso = 2
    }

    public enum TipoIncidencia
    {
        Primera,
        Defecto
    }
}
