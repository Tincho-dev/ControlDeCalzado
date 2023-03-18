using System.ComponentModel.DataAnnotations;

namespace Model.Domain.ControlDeCalzado
{
    public class LineaDeProduccion
    {
        [Key]
        public int IdLinea { get; set; }

        [Display(Name = "Numero de Linea: ")]
        public int NumeroLinea { get; set; }


        //public bool Libre { get; set; } = false;
    }
}
