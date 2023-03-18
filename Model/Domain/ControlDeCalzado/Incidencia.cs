using Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Domain.ControlDeCalzado
{
    public class Incidencia
    {
        [Key]
        public int IdIncidencia { get; set; }

        [Display(Name = "Fecha de la Incidencia: ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaIncidencia { get; set; }

        [Display(Name = "Cantidad de Incidencia: ")]
        public int CantidadIncidencia { get; set; }

        public int? IdDefecto { get; set; }
        [ForeignKey("IdDefecto")]
        public virtual Defecto Defecto { get; set; }
        public Pie Pie { get; set; }
        [Display(Name = "Tipo de la Incidencia: ")]
        public TipoIncidencia Tipo { get; set; }

        public int IdHorarioDeControl { get; set; }
        [ForeignKey("IdHorarioDeControl")]
        public virtual HorarioDeControl HorarioDeControl { get; set; }
    }
}
