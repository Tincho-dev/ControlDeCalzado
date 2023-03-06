using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
