using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Custom
{
    public class OrdenDeProduccionGrid
    {
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

        public string Color { get; set; }

        public string Sku { get; set; }

        public string Modelo { get; set; }


        public int Linea { get; set; }

        //public Alerta Alerta { get; set; }

        public string UserId { get; set; }
        public string Supervisor { get; set; }
    }
}
