using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain.ControlDeCalzado
{
    public class Alerta
    {
        [Key]
        public int IdAlerta { get; set; }
        [Display(Name = "Fecha del Limite: ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaLimite { get; set; }

        [Display(Name = "Fecha del Reinicio: ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaReinicio { get; set; }

        public TipoDefecto TipoDefecto { get; set; }

        public int IdJornada { get; set; }
        [ForeignKey("IdJornada")]
        public JornadaLaboral Jornada { get; set; }

        public int LimiteInferior { get; set; }
        public int LimiteSuperior { get; set; }

        public static string CalcularEstadoSemaforo(int cantidadActual)
        {
            if (cantidadActual < 50)
            {
                return "green";
            }
            else if (cantidadActual < 100)
            {
                return "yellow";
            }
            else
            {
                return "red";
            }
        }
    }
}
