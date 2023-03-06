using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common;

namespace Model.Domain.ControlDeCalzado
{
    public class OrdenDeProduccion
    {
        [Key]
        public string Numero { get; set; }
        public EstadoOp Estado { get; set; }

        [Required(ErrorMessage = "Fecha de Inicio necesaria:")]
        [Display(Name = "Fecha de Inicio: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaDeInicio { get; set; }

        [Display(Name = "Fecha de Fin: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaDeFin { get; set; }

        [Display(Name = "Cantidad de Primera: ")]
        public int CantidadDePrimera { get; set; }


        [Display(Name = "Cantidad por Hermanado: ")]
        public int CantidadPorHermanado { get; set; }

        public string CodigoColor { get; set; }
        [ForeignKey("CodigoColor")]
        public virtual Color Color { get; set; }

        public string Sku { get; set; }
        [ForeignKey("Sku")]
        public virtual Modelo Modelo { get; set; }

        public int IdLinea { get; set; }
        [ForeignKey("IdLinea")]
        [Display(Name = "Linea de Produccion: ")]
        public virtual LineaDeProduccion LineaDeProduccion { get; set; }

        //public Alerta Alerta { get; set; }
        public List<JornadaLaboral> Jornadas { get; set; } = new List<JornadaLaboral>();
        
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get;   set; }

    }
}
