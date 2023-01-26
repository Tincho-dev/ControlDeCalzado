using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Domain.ControlDeCalzado
{
    public class OrdenDeProduccion
    {
        public int Numero { get; set; }

        public DateTime FechaDeInicio { get; set; }
        public DateTime FechaDeFin { get; set; }

        [Display(Name = "Cantidad de Primera: ")]
        public int CantidadDePrimera { get; set; }

        [Display(Name = "Cantidad por Hermanado: ")]
        public int CantidadPorHermanado { get; set; }
    }
}
