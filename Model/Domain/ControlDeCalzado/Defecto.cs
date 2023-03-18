using Common;
using System.ComponentModel.DataAnnotations;

namespace Model.Domain.ControlDeCalzado
{
    public class Defecto
    {
        [Key]
        public int IdDefecto { get; set; }
        [Display(Name = "Descripcion del Defecto: ")]
        public string DescripcionDefecto { get; set; }
        [Display(Name = "Tipo del Defecto: ")]
        public TipoDefecto TipoDefecto { get; set; }
    }
}
