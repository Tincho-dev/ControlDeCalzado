using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Domain.ControlDeCalzado
{
    public class Turno
    {
        [Key]
        public int IdTurno { get; set; }

        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hora de Inicio: ")]
        public TimeSpan HoraDeInicio { get; set; }
        
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hora de Fin: ")]
        public TimeSpan HoraDeFin { get; set; }

    }
}
