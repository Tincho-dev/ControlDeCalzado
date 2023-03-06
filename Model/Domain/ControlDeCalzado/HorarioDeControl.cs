using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain.ControlDeCalzado
{
    public class HorarioDeControl
    {
        [Key]
        public int IdHorarioDeControl { get; set; }

        [Display(Name = "Hora de Inicio: ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HoraInicio { get; set; }

        [Display(Name = "Hora de Fin: ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HoraFin { get; set; }

        public int IdJornada { get; set; }
        [ForeignKey("IdJornada")]
        [Display(Name = "Jornada Laboral: ")]
        public virtual JornadaLaboral JornadaLaboral { get; set; }

        public List<Incidencia> Incidencias { get; set; }
    }
}
