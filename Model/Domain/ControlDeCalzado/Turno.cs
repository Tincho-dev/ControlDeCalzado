using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Domain.ControlDeCalzado
{
    public class Turno
    {

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hora de Inicio: ")]
        public DateTime HoraDeInicio { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hora de Fin: ")]
        public DateTime HoraDeFin { get; set; }
    }
}
