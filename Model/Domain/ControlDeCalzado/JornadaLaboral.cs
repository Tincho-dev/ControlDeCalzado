using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain.ControlDeCalzado
{
    public class JornadaLaboral
    {
        [Key]
        public int IdJornada { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicioJornada { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaFinJornada { get; set; }

        [Display(Name = "Turno:")]
        public int IdTurno { get; set; }
        [ForeignKey("IdTurno")]
        public virtual Turno Turno { get; set; }

        [Display(Name = "Orden de Produccion Nro:")]
        public string Numero { get; set; }
        [ForeignKey("Numero")]
        public virtual OrdenDeProduccion OrdenDeProduccion { get; set; }

        public List<Alerta> Alertas { get; set; } = new List<Alerta>();

        public List<HorarioDeControl> HorariosDeControl { get; set; } = new List<HorarioDeControl>();

    }
}
