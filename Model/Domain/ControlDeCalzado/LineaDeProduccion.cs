using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain.ControlDeCalzado
{
    public class LineaDeProduccion
    {

        [Display(Name = "Numero de Linea: ")]
        public int NumeroLinea { get; set; }
    }
}
