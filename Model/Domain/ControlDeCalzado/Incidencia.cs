using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain.ControlDeCalzado
{
    public class Incidencia
    {

        [Display(Name = "Fecha de la Incidencia: ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaIncidencia { get; set; }

        [Display(Name = "Cantidad de Incidencia: ")]
        public int CantidadIncidencia { get; set; }
    }
}
