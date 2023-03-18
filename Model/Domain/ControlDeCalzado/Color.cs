using System.ComponentModel.DataAnnotations;

namespace Model.Domain.ControlDeCalzado
{
    public class Color
    {
        [Key]
        [Display(Name = "Codigo del Color: ")]
        public string CodigoColor { get; set; }

        [Display(Name = "Descripcion del Color: ")]
        public string DescripcionColor { get; set; }
    }
}
